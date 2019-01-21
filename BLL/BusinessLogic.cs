using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BusinessLogic
    {
        DataAccess da;

        public int UserId { get; set; }

        public BusinessLogic()
        {
            da = new DataAccess();
        }

        private bool EmailKontrol(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public int LoginKontrol(string email, string sifre)
        {
            int ret = 0;

            bool kontrol = EmailKontrol(email);
            if (kontrol && !string.IsNullOrEmpty(sifre))
            {
                UserId = da.LoginKontrol(email, sifre);
                ret = UserId;

            }
            else
            {
                da.HataVar("Uygun Email değil!!!");
                ret = -1;
            }

            return ret;
        }

        //public int KullaniciKaydet(string ad,string soyad,string email,string telefon,string sifre,string ilce,DateTime dogumtarihi,int cinsiyet,int[] spor)
        //{
        //    int kayitSayisi;
        //    bool kontrol = EmailKontrol(email);

        //    if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad) && kontrol)
        //    {              
        //        kayitSayisi = da.KullaniciKaydet(ad, soyad, email, telefon, sifre, ilce, dogumtarihi, cinsiyet,spor);
        //    }

        //    else
        //    {
        //        kayitSayisi = -1;
        //    }

        //    return kayitSayisi;
        //}

        //public int EtkinlikAc(string etkinlikAd,int tipId,int mekanId,DateTime etkinlikTarihi,int kontenjan,int sporId)
        //{
        //    int kayitSayisi;

        //    if (!string.IsNullOrEmpty(etkinlikAd)&& !string.IsNullOrEmpty(etkinlikTarihi.ToString()))
        //    {    
        //        kayitSayisi = da.EtkinlikAc(etkinlikAd, tipId, mekanId, etkinlikTarihi, kontenjan, sporId);
        //    }

        //    else
        //    {
        //        kayitSayisi = -1;
        //    }

        //    return kayitSayisi;
        //}

        //public int MekanAc(string mekanAdi, int ilceId)
        //{
        //    int kayitSayisi;

        //    if (!string.IsNullOrEmpty(mekanAdi))
        //    {
        //        kayitSayisi = da.MekanAc(mekanAdi, ilceId);
        //    }
        //    else
        //    {
        //        kayitSayisi = -1;
        //    }

        //    return kayitSayisi;
        //}

        public List<T> SporAl<T>()
        {
            List<T> spor = da.SporGetir<T>();
            return spor;
        }


        public List<T> Iller<T>()
        {

            List<T> il = da.IlAl<T>();

            return il;
        }

        public List<T> Ilceler<T>(int sehir)
        {


            List<T> ilce = da.IlceAl<T>(sehir);

            return ilce;
        }

        public List<T> EtkinlikAl<T>()
        {
            List<T> etkinlik = da.EtkinlikAl();
            return etkinlik;
        }
        public List<T> EtkinlikTipAl<T>()
        {
            List<T> etip = da.EtkinlikTipAl();
            return etip;
        }
        public List<T> MekanAl<T>()
        {
            List<T> mekan = da.MekanAl();
            return mekan;
        }

        public int Katil(int eid, int kid)
        {
            return da.Katil(eid, kid);
        }
    }
       
}
