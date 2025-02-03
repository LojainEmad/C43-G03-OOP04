using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Third_Project
{
    internal abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalcDiscount(decimal price, int quantity);
    }
}
