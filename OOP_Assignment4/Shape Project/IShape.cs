using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Shape_Project
{
    internal interface IShape
    {
        //by dafault public 
        double Area { get; }  //will be calculated based on areas so no set , //signature for property

        void DispalyShapeInfo();

    }
}
