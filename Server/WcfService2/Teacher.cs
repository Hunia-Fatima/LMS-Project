using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class Teacher
    {

        [DataMember]
        bool Status;
        [DataMember]
        string name;
        [DataMember]
        string password;
        [DataMember]
        string email;
        [DataMember]
        string pincode;
        [DataMember]
        string subject;
        [DataMember]
        string department;
        public bool getstatus()
        {
            return Status;
        }
        public void setstatus(bool a)
        {
            Status = a;
        }
        public string getname()
        {
            return name;
        }
        public void setname(string s)
        {
            name = s;
        }

        public string getdepartment()
        {
            return department;
        }
        public void setdepartment(string s)
        {
            department = s;
        }

        public string getpincode()
        {
            return pincode;
        }
        public void setpincode(string s)
        {
            pincode = s;
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
        public string getsubject()
        {
            return subject;
        }
        public void setsubject(string s)
        {
            subject = s;
        }
    }
}