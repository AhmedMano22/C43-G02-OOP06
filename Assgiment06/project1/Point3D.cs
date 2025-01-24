using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment06.project1
{
    internal class Point3D : ICloneable
    {
        #region attributes
        public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        #endregion

        #region Constructor
            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        #endregion

        #region Methods

        override public string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
                return X == other.X && Y == other.Y && Z == other.Z;
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y, Z).GetHashCode();
        }


        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !p1.Equals(p2);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public static Point3D ReadPointFromUser(string pointName)
        {
            Console.WriteLine($"Enter coordinates for {pointName}:");
            int x, y, z;

            Console.Write("X: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter an integer for X.");
            }

            Console.Write("Y: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input. Please enter an integer for Y.");
            }

            Console.Write("Z: ");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Invalid input. Please enter an integer for Z.");
            }

            return new Point3D(x, y, z);
        }
        #endregion
    }
}
