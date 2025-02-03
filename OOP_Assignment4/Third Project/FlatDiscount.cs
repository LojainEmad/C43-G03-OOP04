using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Third_Project
{
    internal class FlatDiscount : Discount
    {

        public decimal FlatAmount { get; }

        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
            Name = "Flat Discount";
        }

        public override decimal CalcDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }

}
