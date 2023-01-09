using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticClass
{
    public static partial class Operation
    {

       public static void AddRegistration()
       {
         StudentDetails student1=new StudentDetails("Arul","berk","Male",21);
         studentList.Add(student1);
       }
       
    }
}