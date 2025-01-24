using Assgiment06.project1;
using Assgiment06.project2;
using Assgiment06.project3;

namespace Assgiment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project01
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            ////Point3D P1 = Point3D.ReadPointFromUser("P1");
            ////Point3D P2 = Point3D.ReadPointFromUser("P2");

            ////// Test the == operator
            ////Console.WriteLine($"P1 = {P1}");
            ////Console.WriteLine($"P2 = {P2}");
            ////Console.WriteLine($"P1 == P2: {P1 == P2}");

            //Point3D[] points = { 
            //    new Point3D(5, 2, 8),
            //    new Point3D(1, 9, 7), 
            //    new Point3D(3, 4, 6) 
            //};

            //Array.Sort(points, (a, b) => a.X == b.X ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));
            //Console.WriteLine("Sorted Points result:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //// Clone a point
            //Point3D P3 = (Point3D)points[0].Clone();
            //Console.WriteLine($"Cloned Point: {P3}"); 
            #endregion

            #region Project02
            //Console.WriteLine($"Addition: {Maths.Add(5, 10)}");
            //Console.WriteLine($"Subtraction: {Maths.Subtract(6, 3)}");
            //Console.WriteLine($"Multiplication: {Maths.Multiply(10, 2)}");
            //Console.WriteLine($"Division: {Maths.Divide(8, 2)}");
            #endregion

            #region Project03
            //Console.WriteLine("Enter your user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine().ToLower();
            //Console.WriteLine(userType);


            //User user ;
            //switch (userType)
            //{
            //    case "regular":
            //        user = new RegularUser("Regular User");
            //        break;
            //    case "premium":
            //        user = new PremiumUser("Premium User");
            //        break;
            //    case "guest":
            //        user = new GuestUser("Guest User");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type.");
            //        return;
            //}


            //// Ask the user to input product details
            //Console.WriteLine("Enter product price:");
            //decimal price = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter product quantity:");
            //int quantity = int.Parse(Console.ReadLine());


            //Discount discount = user.GetDiscount();

            //decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            //decimal finalPrice = price * quantity - discountAmount;

            //Console.WriteLine($"Total Discount: {discountAmount}");
            //Console.WriteLine($"Final Price: {finalPrice}");
            #endregion
        }
    }
}
