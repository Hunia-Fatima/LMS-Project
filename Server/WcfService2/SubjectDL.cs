using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class SubjectDL
    {
        public static List<Subject> subjects = new List<Subject>();
    }
}