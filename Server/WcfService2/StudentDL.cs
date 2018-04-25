using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class StudentDL
    {
        [DataMember]
        public static List<Student> students = new List<Student>();
    }
}