using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public bool IsValid(string username, string password)
        {
            Admin admin = new Admin();
            if (admin.getname() == username && admin.getpassword() == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void registerUser(string username, string password, string email, string user)
        {
            if (user == "Teacher")
            {
                Teacher teacher = new Teacher();
                teacher.setname(username);
                teacher.setpassword(password);
                teacher.setemail(email);
                TeacherDL.teachers.Add(teacher);
            }
            else if (user == "Student")
            {
                Student student = new Student();
                student.setname(username);
                student.setpassword(password);
                student.setemail(email);
                StudentDL.students.Add(student);
            }
        }
        public bool IsValidTeacher(string username, string password)
        {
            bool found = false;
            foreach (Teacher t in TeacherDL.teachers)
            {
                if (t.getname() == username && t.getpassword() == password)
                {
                    found = true;
                    return found;
                }               
            }
            return found; 
        }
        public bool IsValidStu(string username, string password)
        {
            foreach (Student s in StudentDL.students)
            {
                if (s.getname() == username && s.getpassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
        
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
