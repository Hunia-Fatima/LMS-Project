using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    [DataContract]
    public class Attendance
    {
        [DataMember]
        public string Student;

        public string getStudent()
        {
            return Student;
        }
        public void setStudent(string S)
        {
            Student = S;
        }
        [DataMember]
        public string percentage;

        public string getpercentage()
        {
            return percentage;
        }
        public void setpercentage(string S)
        {
            percentage = S;
        }
        [DataMember]
        public string sub;
        public string getsub()
        {
            return sub;
        }
        public void setsub(string S)
        {
            sub = S;
        }
       
        [DataMember]
        public Teacher teacher;
        public Teacher getteacher()
        {
            return teacher;
        }
        public void setteacher(Teacher S)
        {
            teacher = S;
        }
       
         [DataMember]
        public string Section;

         public string getSection()
         {
             return Section;
         }
         public void setSection(string Sec)
         {
             Section = Sec;
         }
         [DataMember]
        public string Semester;
         public string getsemester()
         {
             return Semester;
         }
         public void setSemester(string S)
         {
             Semester = S;
         }
       
    }
}