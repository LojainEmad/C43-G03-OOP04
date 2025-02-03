using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Security_Module
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if(!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                if (username == "LojainEmad" && password == "1234")        //compare here with static data
                    return true;
                else 
                    return false;
            }
            return false;

        }

        public bool AuthorizeUser(string username, string role)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(role))
            {
                if (username == "LojainEmad" && role == "Admin")        //compare here with static data
                    return true;
                else
                    return false;
            }
            return false;

        }
    }
}
