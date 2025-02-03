using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Shape_Project
{
    internal class Rectangle : IRectangle

    {
        public int Width { get ; set ; }
        public int Height { get; set; }
        public double Area
        {
            get { return Width * Height; }
        }


        public void DispalyShapeInfo()
        {
            Console.WriteLine($"the rectangle Width is :{Width} and Height : {Height} and the Area is {Area}");
        }
    }
}
