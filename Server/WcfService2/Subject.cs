using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class Subject
    {
        [DataMember]
        string name;
        [DataMember]
        string teacher;
        bool isregistered = false;
        public string getname()
        {
            return name;
        }
        public void setname(string n)
        {
            name = n;
        }
        public string getteacher()
        {
            return teacher;
        }
        public void setteacher(string t)
        {
            teacher = t;
        }
        public bool getstatus()
        {
            return isregistered;
        }
        public void setstatus(bool b)
        {
            isregistered = b;
        }
    }
}