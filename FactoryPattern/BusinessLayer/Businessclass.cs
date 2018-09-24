using System;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessClass
    {
        public string Validate(string email, string password)
        {
            Data dataObj = new Data();
            for (int index = 0; index < dataObj.username.Length; index++)
            {
                if (email == dataObj.username[index] && password == dataObj.password[index])
                {
                    return "User" + Convert.ToString(index + 1);
                }
            }
            return "Invalid";
        }
        public IGetDetails GetDetails(string user)
        {

            if (user == "User1")
            {
                return new UserOneClass();
            }
            else if (user == "User2")
            {
                return new UsertwoClass();
            }
            else if (user == "User3")
            {
                return new UserthreeClass();
            } 
            else
            {
                return null;
            }
        }
    }
}
