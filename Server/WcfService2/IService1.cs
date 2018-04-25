﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        List<Teacher> SearchByDepartment(string Department);
        [OperationContract]

        List<Teacher> SearchByname(string Name);

        [OperationContract]
        void registerStudent(string username, string password, string email, string pincode,string section);
        [OperationContract]
        void registerTeacher(string username, string password, string email, string pincode, string subject , string department);
        [OperationContract]
        bool IsValid(string username,string password);
        [OperationContract]
        bool resetpaswrd(string name, string pin,string user);
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        bool IsValidTeacher(string username, string password);
        [OperationContract]
        bool IsValidStu(string username, string password);
        [OperationContract]
        List<Student> SearchByName(string UserName);
        [OperationContract]
        List<Student> SearchBySection(string section);
        [OperationContract]
        List<Student> ShowAll();
        [OperationContract]
        List<Teacher> showall();
        [OperationContract]
        void registerSubject(Student student, Subject subject);
        [OperationContract]
        void unregisterSubject(Student student, Subject subject);
        [OperationContract]
        List<Subject> getSubjects();
        [OperationContract]
        Student loggedInStudent();
        [OperationContract]
        List<Subject> loggedInStudentSubject();
        [OperationContract]
        void AddResult( string name,string section, string marksobtained, string totalmarks, string status);
        [OperationContract]
        List<AddallResult> showResult();
        [OperationContract]
        List<AddallResult> BySection(string section);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
