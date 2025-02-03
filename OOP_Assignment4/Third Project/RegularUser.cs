using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Assignment4.Third_Project
{
    internal class RegularUser:User
    {

        public RegularUser()
        {
            Name = "Regular User";
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
