using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Shape_Project
{
    internal interface IRectangle:IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
