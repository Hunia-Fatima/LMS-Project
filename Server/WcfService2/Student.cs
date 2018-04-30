using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class Student
    {
        [DataMember]
        string Name;
        [DataMember]
        string Password;
        [DataMember]
        string Email;
        [DataMember]
        string Pincode;
        [DataMember]
        string Section;
        [DataMember]
        public List<Subject> subjects = new List<Subject>();
        [DataMember]
        public List<Result> results = new List<Result>();

        public string getSection()
        { 
            return Section; 
        }
        public void setSection(string Sec)
        {
            Section = Sec;
        }
        public string getname()
        {
            return Name;
        }
        public void setname(string s)
        {
            Name = s;
        }
        public string getpincode()
        {
            return Pincode;
        }
        public void setpincode(string s)
        {
            Pincode = s;
        }
        public string getpassword()
        {
            return Password;
        }
        public void setpassword(string s)
        {
            Password = s;
        }
        public string getemail()
        {
            return Email;
        }
        public void setemail(string s)
        {
            Email = s;
        }
        public string getSec()
        {
            return Section;
        }
        public void setSec(string s)
        {
            Section = s;
        }
    }
}