using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Security_Module
{
    internal class AdvancedAuthService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "Logy" && password == "5678")
                return true;
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "Logy" && role == "User")
                return true;
            return false;
        }
    }
}
