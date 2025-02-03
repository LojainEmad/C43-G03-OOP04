using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Third_Project
{
    internal abstract class User
    {
       
        public string Name { get; protected set; }
        public abstract Discount GetDiscount();
    }
}
