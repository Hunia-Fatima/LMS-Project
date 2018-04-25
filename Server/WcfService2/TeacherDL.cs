using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class TeacherDL
    {
        public static List<Teacher> teachers = new List<Teacher>();
    }
}