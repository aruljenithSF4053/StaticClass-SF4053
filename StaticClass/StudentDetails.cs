using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticClass
{
    public class StudentDetails
    {
        private static int _studentID=1000;
        public string StudentID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Gender{get;set;}
        public int Age{get;set;}

        public StudentDetails(string name,string fatherName,string gender,int age)
        {
            _studentID++;
            StudentID="SID"+_studentID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Age=age;        
        }
    }
}