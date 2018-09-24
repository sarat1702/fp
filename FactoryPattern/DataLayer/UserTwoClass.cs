using System;

namespace DataLayer
{
    public class UsertwoClass : IGetDetails
    {
        Data userDataObject = new Data();
        public void PrintDetails()
        {
            Console.WriteLine(userDataObject.userData[1]);
            Console.WriteLine("1 , abc");
            Console.WriteLine("2 , def");
            Console.WriteLine("3 , ghi");
        }
    }
}