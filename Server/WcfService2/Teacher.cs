using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Teacher
    {
        string name;
        string password;
        string email;
        public string getname()
        {
            return name;
        }
        public void setname(string s)
        {
            name = s;
        }
        public string getpassword()
        {
            return password;
        }
        public void setpassword(string s)
        {
            password = s;
        }
        public string getemail()
        {
            return email;
        }
        public void setemail(string s)
        {
            email = s;
        }
    }
}