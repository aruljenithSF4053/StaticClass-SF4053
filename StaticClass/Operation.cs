using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticClass
{
    public static partial class Operation
    {
        static List<StudentDetails> studentList=new List<StudentDetails>();
        public static void Regitration()
        {
            System.Console.WriteLine("Enter Student Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Father Name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Gender:");
            string gender=Console.ReadLine();
            System.Console.WriteLine("Enter Studetn Age:");
            int age=int.Parse(Console.ReadLine());

            StudentDetails student1=new StudentDetails(name,fatherName,gender,age);
            studentList.Add(student1);
            
        }

        public static void ShowDetails()
        {
            foreach(StudentDetails student in studentList)
            {
                System.Console.WriteLine(student.StudentID+"||"+student.Name+"||"+student.FatherName+"||"+student.Gender+"||"+student.Age);
            }
        }


    }
}