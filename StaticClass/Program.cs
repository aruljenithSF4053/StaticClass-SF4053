using System;
namespace StaticClass;
class Program
{
    public static void Main(string[] args)
    {
        Operation.Regitration();
        Operation.AddRegistration();
        Operation.ShowDetails();
       // Operation oper=new Operation(); cannot craete the instance of static class.
    }
}