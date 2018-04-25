using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{    [DataContract]
    public class AddAllResultDL
    {
        [DataMember]
        public static List<AddallResult> addresult = new List<AddallResult>();
    }

}