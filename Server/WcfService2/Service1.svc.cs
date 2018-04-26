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
        public static Student st = null;

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
        public void registerTeacher(string username, string password, string email, string pincode, string subject , string department)
        {
            Teacher teacher = new Teacher();
            teacher.setname(username);
            teacher.setpassword(password);
            teacher.setemail(email);
            teacher.setpincode(pincode);
            teacher.setsubject(subject);
            teacher.setdepartment(department);
            Subject s = new Subject();
            s.setname(subject);
            s.setteacher(teacher.getname());
            SubjectDL.subjects.Add(s);
            TeacherDL.teachers.Add(teacher);
        }
        public void registerStudent(string username, string password, string email, string pincode,string section)
        {
            Student student = new Student();
            student.setname(username);
            student.setpassword(password);
            student.setemail(email);
            student.setpincode(pincode);
            student.setSec(section);
            StudentDL.students.Add(student);
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
                    st = s;
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
                string n = p.getname();
                if (n.Contains(UserName))
                {
                    stu.Add(p);
                }
            }
            return stu;
 
        }
        public List<Subject> getSubjects()
        {
            List<Subject> subjects = SubjectDL.subjects;
            return subjects;
        }

        public void registerSubject(Student student, Subject subject)
        {

            Subject sub = new Subject();
            st.subjects.Add(sub);
        }
        public void unregisterSubject(Student student, Subject subject)
        {
            Student s = new Student();
            s = st;
            Subject sub = new Subject();
            s.subjects.Remove(sub);
        }
        public Student loggedInStudent()
        {
            return st;
        }
        public List<Subject> loggedInStudentSubject()
        {
            List<Subject> s = st.subjects;
            return s;
        }
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Teacher> SearchByname(string Name)
        {
            List<Teacher> arr = new List<Teacher>();
            foreach (Teacher t in TeacherDL.teachers)
            {
                if (Name == t.getname())
                {
                    arr.Add(t);
                }
            }
            return arr;
        }

        public List<Teacher> SearchByDepartment(string Department)
        {
            List<Teacher> arr = new List<Teacher>();
            foreach (Teacher t in TeacherDL.teachers)
            {
                if (Department == t.getdepartment())
                {
                    arr.Add(t);
                }
            }
            return arr;
        }


        public List<Teacher> showall()
        {
            return TeacherDL.teachers;
        }
         public void AddResult(string name, string section, string marksobtained, string totalmarks, string status)
        {
            AddallResult add = new AddallResult();
            add.setName(name);
            add.setSection(section);
            add.setMarkobtained(marksobtained);
            add.setTotalmarks(totalmarks);
            add.setStatus(status);
            AddAllResultDL.addresult.Add(add);
        }
        public List<AddallResult> showResult()
        {

            return AddAllResultDL.addresult;

        }
        public List<AddallResult> BySection(string section)
        {

            List<AddallResult> ad = new List<AddallResult>();
            
                foreach (AddallResult d in AddAllResultDL.addresult)
                {
                    if (section == d.getSection())
                    {
                      ad.Add(d);
                }
                }
            return ad;

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
