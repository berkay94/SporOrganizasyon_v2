using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporOrganizasyon
{
    public static class Param
    {
        private static String userName;

        public static String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private static string kayitTipi;

        public static string KayitTipi
        {
            get { return kayitTipi; }
            set { kayitTipi = value; }
        }

        private static int userId;

        public static int UserID
        {
            get { return userId; }
            set { userId = value; }
        }


    }
}
