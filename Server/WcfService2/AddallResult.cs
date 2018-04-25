using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class AddallResult
    {
        [DataMember]
        private string Name;
        [DataMember]
        private string Section;

        [DataMember]
        private string Markobtained;

        [DataMember]
        private string Totalmarks;

        [DataMember]
        private string Status;


        public string getName()
        {
            return Name;
        }
        public void setName(string n)
        {
            Name = n;
        }


        public string getSection()
        {
            return Section;
        }
        public void setSection(string s)
        {
            Section = s;
        }

        public string getMarkobtained()
        {
            return Section;
        }
        public void setMarkobtained(string m)
        {
            Markobtained = m;
        }


        public string getTotalmarks()
        {
            return Totalmarks;
        }
        public void setTotalmarks(string t)
        {
            Totalmarks = t;
        }

        public string getStatus()
        {
            return Status;
        }
        public void setStatus(string s)
        {
            Status = s;
        }

    }
}
