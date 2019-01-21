using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DALLINQ
{
    
    public class DataAccess
    {
        SporODataContext sporo = new SporODataContext();
        string kayitTipi = System.Configuration.ConfigurationManager.AppSettings["KayitTipi"];
    }

    //public int KullaniciKaydet(Kullanici k ,int[]s)
    //{

    //}
}
