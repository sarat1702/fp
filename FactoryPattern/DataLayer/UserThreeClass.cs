using System;

namespace DataLayer
{
    public class UserthreeClass : IGetDetails
    {
        Data userDataObject = new Data();
        public void PrintDetails()
        {
            Console.WriteLine(userDataObject.userData[2]);
            Console.WriteLine("1 , abc");
            Console.WriteLine("2 , def");
            Console.WriteLine("3 , ghi");
        }
    }
}