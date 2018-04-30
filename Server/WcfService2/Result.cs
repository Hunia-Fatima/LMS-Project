using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class Result
    {
        [DataMember]
        string Student;
        [DataMember]
        string total_marks;
        [DataMember]
        string obtained_marks;
        [DataMember]
        string subject;
        public string getstudent()
        {
            return Student;
        }
        public void setstudent(string s)
        {
            Student = s;
        }
        public string getsubject()
        {
            return subject;
        }
        public void setsubject(string s)
        {
            subject = s;
        }
        public string gettotal()
        {
            return total_marks;
        }
        public void settotal(string s)
        {
            total_marks = s;
        }
        public string getmarks()
        {
            return obtained_marks;
        }
        public void setmarks(string s)
        {
            obtained_marks = s;
        }
    }
}