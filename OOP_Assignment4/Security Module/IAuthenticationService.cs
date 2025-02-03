using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Security_Module
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);  //by default public 
        bool AuthorizeUser(string username, string role);
    }
}
