using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaOfCircle
{
    class CalculateAreaOfCircle
    {
        private const double PI = 3.14159;

                static void Main(string[] args)
        {

            string calculateAnother = "";
            do
            {
                Console.WriteLine("Enter a value for the radius of the circle.");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = CalculateArea(radius);
                Console.WriteLine("area = {0, 4:F8}", area);
                Console.WriteLine("do you wish to calculate another circle? Y for Yes, N for no");
                calculateAnother = Console.ReadLine();
            } while (calculateAnother.ToLower() == "y");



        }
            // using Lamda expression style for method.
            static double CalculateArea(double r) => 3.1415926535897938463643383279 * r * r; // pi to 30 digits.
        
    }
}
