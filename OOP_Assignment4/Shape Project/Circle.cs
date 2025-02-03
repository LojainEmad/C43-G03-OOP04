using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Shape_Project
{
    public class Circle : ICircle   //Must provide implementation for redius , Area,Display
    {
        public double Radius { get ; set; }  //normal property

        public double Area
        {
            get {  return Radius * Radius *3.14; }
        
        }

        public void DispalyShapeInfo()
        {
            Console.WriteLine($"the Redius of the Circle : {Radius} , and the Area : {Area}");
        }
    }
}
