using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Assignment4.Third_Project
{
    internal class GuestUser:User
    {
        public GuestUser()
        {
            Name = "i am Guest User";
        }
        public override Discount GetDiscount()
        {
            return null; 
        }
    }
}
