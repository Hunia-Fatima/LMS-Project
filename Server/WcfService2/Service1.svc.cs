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
        public static Teacher tr = null;

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

        public Result Viewresult(Student s)
        {
            Result b = new Result();
            
            foreach (Result r in ResultDL.results)
            {
                
                if(r.getstudent() == s.getname())
                {
                    b = r;
                    return r ;
                }

            }
            return b;   
        }

        public bool IsValidTeacher(string username, string password)
        {
            bool found = false;
            foreach (Teacher t in TeacherDL.teachers)
            {
                if (t.getname() == username && t.getpassword() == password)
                {
                    found = true;
                    tr = t;
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
            sub = subject;
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
        public List<Teacher> SearchByname(string Name)
        {
            List<Teacher> arr = new List<Teacher>();
            foreach (Teacher t in TeacherDL.teachers)
            {
                string g = t.getname();
                if (g.Contains(Name))
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
        public List<String> registered_students()
        {
            List<String> str = new List<string>();
            foreach (Student s in StudentDL.students)
            {
                foreach (Subject sb in s.subjects)
                {
                    if (sb.getteacher() == tr.getname())
                    {
                        str.Add(s.getname());
                    }
                }
            }
            return str;
        }
        public List<Student> get_registered_students()
        {
            return StudentDL.students;
        }
        public Teacher getLoggedInTeacher()
        {
            return tr;
        }
        public void Add_result(string student,string subject,string total,string marks)
        {
            Result res = new Result();
            res.setstudent(student);
            res.setsubject(subject);
            res.settotal(total);
            res.setmarks(marks);
            ResultDL.results.Add(res);
        }
        public  List<Result> get_result()
        {
            return ResultDL.results;
        }
        public void update_result(Result res)
        {
            foreach (Student s in StudentDL.students)
            {
                if (s.getname() == res.getstudent())
                {
                    Result r = new Result();
                    r = res;
                    s.results.Add(r);
                }
            }
        }

        public void AddAttendance(string name, string Attendance, string section, string subject, Teacher t)
        {
            Attendance Atten = new Attendance();
            Atten.setStudent(name);
            Atten.setpercentage(Attendance);
            Atten.setSection(section);
            Atten.setsub(subject);
            Atten.setteacher(t);
            foreach (Student s in StudentDL.students)
            {
                if (s.getname() == name)
                {
                    s.attendance.Add(Atten);
                }
            }
            AttendanceDL.Attendances.Add(Atten);
           
        }
        /*
        public bool ValRegstrdStu(string name)
        {
            Teacher t = getLoggedInTeacher();
            foreach (Student s in StudentDL.students)
            {
                if (s.getname() == name)
                {
                    List<Subject> sub = getSubjects();
                    foreach (Subject S1 in sub)
                    {
                        if (S1.getname() == t.getsubject())
                        {
                            return true;
                        }
                        else 
                        {
                            return false;
                        }
                    }
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }g
        */

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
