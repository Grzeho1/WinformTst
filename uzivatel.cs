using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Text;

namespace Projekt
{
    internal class Uzivatel
    {
        static string login;
        static string heslo;
        static string? email;
        

        public static string Login
        {

            get
            { return login;  }
            set
            { login = value;  }
        }
        public static string Heslo
        {
            get { return heslo; }
            set { heslo = value; }
        }

        public static string Email
        {
            get;set;
            
        }



        


    }

    
}
