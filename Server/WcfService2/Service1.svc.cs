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
        public void registerUser(string username, string password, string email,string pincode, string sec, string user)
        {
            if (user == "Teacher")
            {
                Teacher teacher = new Teacher();
                teacher.setname(username);
                teacher.setpassword(password);
                teacher.setemail(email);
                teacher.setpincode(pincode);
                TeacherDL.teachers.Add(teacher);
            }
            else if (user == "Student")
            {
                Student student = new Student();
                student.setname(username);
                student.setpassword(password);
                student.setemail(email);
                student.setpincode(pincode);
                student.setSection(sec);
                StudentDL.students.Add(student);
            }
        }

        public List<Student> ShowAll()
        {
            return StudentDL.students;
        }
        public bool resetpaswrd(string name, string pincode, string user)
        {
            string password = "1234asdf";
            if (user == "Student")
            {
                foreach (Student st in StudentDL.students)
                {
                    if (st.getname() == name && st.getpincode() == pincode)
                    {
                        st.setpassword(password);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (Teacher t in TeacherDL.teachers)
                {
                    if (t.getname() == name && t.getpincode() == pincode)
                    {
                        t.setpassword(password);
                        return true;
                    }
                }
                return false;
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
        public List<Student> SearchBySection(string section)
        {
            List<Student> stu = new List<Student>();
            foreach (Student p in StudentDL.students)
            {
                if (section == p.getSection())
                {
                    stu.Add(p);
                }
            }
            return stu;
        }

        public List<Student> SearchByName(string UserName)
        {
            List<Student> stu = new List<Student>();
            foreach (Student p in StudentDL.students)
            {
                if (UserName == p.getname())
                {
                    stu.Add(p);
                }
            }
            return stu;
 
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
