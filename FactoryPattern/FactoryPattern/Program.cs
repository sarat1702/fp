using System;
using BusinessLayer;
using DataLayer;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email Id");
            string emailId = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            BusinessClass obj = new BusinessClass();
            string user = obj.Validate(emailId, password);
            if (user == "Invalid")
            {
                Console.WriteLine("Enter valid Email Id password");
            }
            else
            {
                IGetDetails detailsObject = obj.GetDetails(user);
                detailsObject.PrintDetails();
            }
            Console.ReadKey();
        }
    }
}
