using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Admin
    {
        string name = "ADMIN";
        string password = "Admin123";
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
    }
}