using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Point_Project
{
    internal class Point3D : IComparable, ICloneable
    {
        #region Automatic properties
        public int P1 { get; set; }
        public int P2 { get; set; }
        public double P3 { get; set; }
        #endregion

        #region Constructors
        public Point3D(int p1, int p2, int p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        //constructor chaining
        public Point3D(int p1, int p2) : this(p1, p2, 0) { }

        public Point3D(int p1) : this(p1, 0, 0) { }

        //copy constructor ->take only one parameter ,special type  =>using in deepCopy
        public Point3D(Point3D point3D)
        {   //parameter is the same name as class name 
            P1 = point3D.P1;
            P2 = point3D.P2;
            P3 = point3D.P3;

        }

        #endregion

        #region override functions

        public override string ToString()
        {
            return $"Point Coordinates: ({P1},{P2}, {P3})";
        }


        public override bool Equals(object? obj)    //-> compare obj state to obj state
        {
            if (obj is Point3D point)
            {
                return (P1 == point.P1 && P2 == point.P2 && P3 == point.P3);
            }
            else
                return false;            //if it is not obj

        }
        //after override Equals must also override GetHashCode to return the same address for the points if they have equal values

        public override int GetHashCode()
        {
            return HashCode.Combine(P1, P2, P3);   //return true in the values on the objs are the same 
        }


        #endregion

        #region methods

        public static Point3D CreateNewPoint()
        {
            int p1, p2, p3;
            bool f;

            Console.WriteLine("Enter Point values :");
            do

            {
                Console.WriteLine("enter p1:");
                f = int.TryParse(Console.ReadLine(), out p1);

            } while (!f);

            do

            {
                Console.WriteLine("enter p2:");
                f = int.TryParse(Console.ReadLine(), out p2);

            } while (!f);

            do

            {
                Console.WriteLine("enter p3:");
                f = int.TryParse(Console.ReadLine(), out p3);

            } while (!f);

            return new Point3D(p1, p2, p3);
        }


        public static Point3D[] ArrayPoints(int size)
        {
            Point3D[] points = new Point3D[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter data of teh point{i + 1}");
                points[i] = CreateNewPoint();
            }
            return points;
        }

        public static void PrintPoints(Point3D[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);   //call the toString()
            }



            #endregion

        }

        public int CompareTo(object? obj)
        {
            Point3D point = obj as Point3D;
            if (P1 > point.P1)
                return 1;
            else if (P1 < point.P1)
                return -1;
            else
            {
                if (P2 > point.P2)
                    return 1;
                else return -1;
            }
        }

        public object Clone()
        {
            return new Point3D(this);   //->this means which object will call it
        }
    }
 }
