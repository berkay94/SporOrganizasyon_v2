using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using Dapper;
using System.Data;

namespace DAL
{
    
    
    public class DataAccess
    {
        SqlConnection con;
        string constr = "Data Source=LAPTOP-N5PLE4OO\\SQLEXPRESS;Initial Catalog=SporO;Integrated Security=True";

        public DataAccess()
        {
            con = new SqlConnection(constr);
        }

        public int KullaniciKaydet(Kullanici k,int[] s)
        {
            int kayitSayisi = 0;
            try
            {
               
                string sql = "Insert Into Kullanici(Ad,Soyad,Email,Telefon,Sifre,Ilçe,DogumTarihi,Cinsiyet) Values(@ad,@soyad,@email,@telefon,@sifre,@ılce,@dogumtarihi,@cinsiyet)";

                kayitSayisi = con.Execute(sql, new { @ad = k.Ad, @soyad = k.Soyad, @email = k.Email, @telefon = k.Telefon, @sifre = k.Sifre, @ılce = k.Ilce, @dogumtarihi = k.DogumTarihi, @cinsiyet = k.Cinsiyet });

                KullaniciSpor(s);
                
            }
            catch (Exception ex)
            {
                Hata(ex);
                
            }

            return kayitSayisi;
        }//Bitti

        public int KullaniciSpor(int[]spor)
        {
            int kayitSayisi = 0;
            int kayit = 0;
            try
            {
                foreach (int s in spor)
                {
                    string sql = "Insert Into KullaniciSpor Values(@Kid,@Sid)";
                    var kullanici = con.ExecuteScalar<int>("SELECT IDENT_CURRENT('Kullanici')");
                    kayit = con.Execute(sql, new { @Kid = kullanici, @Sid = s });
                    kayitSayisi += kayit;
                }
                
                    
            }
            catch (Exception ex)
            {

                Hata(ex);
            }

            return kayitSayisi;
        }//Bitti

        public int LoginKontrol(Kullanici k)
        {
            int kayitSayisi = 0;
            try
            {
                var user = con.Query<Kullanici>("Select Kid,Email,isLogin from Kullanici where Email=@Email and Sifre=@Sifre", new { @Email = k.Email, @Sifre = k.Sifre });

                if (user.Count()>0)
                {
                    kayitSayisi = 1;
                    foreach (Kullanici item in user)
                    {

                        if (item.IsLogin == 2)
                        {
                            kayitSayisi = -2;
                        }
                        else
                        {
                            try
                            {
                                var login = con.Query<Kullanici>("IsLoginUser", new { @kid = item.Kid }, commandType: CommandType.StoredProcedure);
                                // update islogin = 2 
                            }
                            catch (Exception ex)
                            {
                                Hata(ex);
                            }
                            finally
                            {
                                kayitSayisi = item.Kid;
                            }
                        }
                        
                    }
                }
                
                else
                {
                    HataVar("Bilgiler Hatali");
                }

                
            }
            catch (Exception ex)
            {
                Hata(ex);

            }

            return kayitSayisi;
        }//Bitti

        public void Logout(int UserId)
        {
            try
            {
                var islogin = con.Query<Kullanici>("Update Kullanici set isLogin = 1 where Kid = @kid", new { @kid = UserId });

            }
            catch (Exception ex)
            {
                Hata(ex);
            }
        }
                
        public int EtkinlikAc(Etkinlikler e)
        {
            int kayitSayisi = 0;
            try
            {
                string sql = "Insert Into Etkinlik(EtkinlikAdi,TipID,MekanID,EtkinlikTarihi,Kontenjan,isActive,Sid) Values(@EtkinlikAdi,@TipID,@MekanID,@EtkinlikTarihi,@Kontenjan,@isActive,@Sid)";

                kayitSayisi=con.Execute(sql,new
                { @EtkinlikAdi = e.EtkinlikAdi, @TipID = e.TipId, @MekanID = e.MekanId, @EtkinlikTarihi = e.EtkinlikTarihi, @Kontenjan = e.Kontenjan, @isActive = e.IsActive, @Sid = e.Sid });

            }
            catch (Exception ex)
            {

                Hata(ex);

            }

            return kayitSayisi;
        }

        public int MekanAc(Mekanlar m)
        {
            int kayitSayisi = 0;
            try
            {
                string sql = "Insert Into Mekan(MekanAdi,IlceId) Values(@MekanAdi,@IlceId)";

                kayitSayisi = con.Execute(sql, new { @MekanAdi = m.MekanAdi, @IlceId = m.IlceId });
            }
            catch (Exception ex)
            {
                Hata(ex);

            }
            return kayitSayisi;
        }//Bitti

        public List<Sporlar> SporGetir()
        {
            List<Sporlar> sporlar=null;
            try
            {
                sporlar = con.Query<Sporlar>("Select * from Sporlar").ToList();
                if (sporlar.Count>0)
                {
                    return sporlar;
                }
                else
                {
                    HataVar("Kayitli spor yok");
                }
            }
            catch (Exception ex)
            {
                Hata(ex);
            }
            return sporlar;
        }

        public List<Iller> IlAl()
        {

            var Iller = con.Query<Iller>("Select * from Iller").ToList();

            return Iller;
        }///Bitti

        public List<Ilce> IlceAl(int sehirId)
        {
          
                var Ilceler = con.Query<Ilce>("Select * from Ilceler Where Sehir=@Sehir",new { @Sehir = sehirId }).ToList();
                
                return Ilceler;
        }//Bitti

        public List<EtkinlikGoster> EtkinlikAl()
        {
            List<EtkinlikGoster> etkinlikler = null;
            try
            {
                var deneme = con.Query<EtkinlikGoster>("EtkinlikAl", commandType: CommandType.StoredProcedure);

                etkinlikler = deneme.ToList();
            }
            catch (Exception ex)
            {
                Hata(ex);
            }
            
            return etkinlikler;
        }

        public List<EtkinlikTip> EtkinlikTipAl()
        {
            var Etipler = con.Query<EtkinlikTip>("Select * from EtkinlikTipi").ToList();

            return Etipler;
        }

        public List<Mekanlar> MekanAl()
        {
            var mekanlar = con.Query<Mekanlar>("Select * from Mekan").ToList();

            return mekanlar;
        }


        public void Hata(Exception ex)
        {
            StackTrace stack = new StackTrace(true);
            foreach (StackFrame frame in stack.GetFrames())
            {
                if (!string.IsNullOrEmpty(frame.GetFileName()))
                {
                    con.Execute("Insert Into HataLoglari(DosyaAdi,MethodAdi,LineNumber,ColumnNumber,Message) Values(@DosyaAdi,@MethodAdi,@LineNumber,@ColumnNumber,@Message)", new { @DosyaAdi = Path.GetFileName(frame.GetFileName()), @MethodAdi = frame.GetMethod().ToString(), @LineNumber = frame.GetFileLineNumber(), @ColumnNumber = frame.GetFileColumnNumber(), @Message = ex.Message.ToString() });

                }
            }
        }//Bitti

        public void HataVar(string mesaj)
        {
            StackTrace stack = new StackTrace(true);
            foreach (StackFrame frame in stack.GetFrames())
            {
                if (!string.IsNullOrEmpty(frame.GetFileName()))
                {
                    con.Execute("Insert Into HataLoglari(DosyaAdi,MethodAdi,LineNumber,ColumnNumber,Message) Values(@DosyaAdi,@MethodAdi,@LineNumber,@ColumnNumber,@Message)", new { @DosyaAdi = Path.GetFileName(frame.GetFileName()), @MethodAdi = frame.GetMethod().ToString(), @LineNumber = frame.GetFileLineNumber(), @ColumnNumber = frame.GetFileColumnNumber(), @Message = mesaj});

                }
            }
        }//Bitti

        public int Katil(int EtkinlikId,int UserId)
        {
            int kayitSayisi = 0;
            try
            {
                string sql = "Insert Into Katilanlar Values(@Eid,@Kid)";
                
                kayitSayisi = con.Execute(sql, new { @Eid = EtkinlikId, @Kid = UserId });

            }
            catch (Exception ex)
            {
                Hata(ex);
            }

            return kayitSayisi;
        }

        public int EtkinlikKisiKontrol(int EtkinlikId, int UserId)
        {
            int ret = 0;

            try
            {
                string sql = "select * from Katilanlar where Eid = @Eid";
                List<Katilanlar> kisiler = con.Query<Katilanlar>(sql, new { @Eid = EtkinlikId }).ToList();

                foreach (Katilanlar kisi in kisiler)
                {
                    if (kisi.Kid == UserId)
                    {
                        ret = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Hata(ex);
            }

            return ret;
        }

    }

}
