using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Assignment4.Third_Project
{
    internal class PercentageDiscount:Discount
    {
        public decimal Percentage { get; }
        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = "Percentage Discount";
        }
        public override decimal CalcDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
