﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Assignment4.Third_Project
{
    internal class PremiumUser:User
    {
        public PremiumUser()
        {
            Name = "i am Premium User";
        }
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

}
