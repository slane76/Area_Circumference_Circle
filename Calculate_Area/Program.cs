using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius, area, circumference, radiusSquared;
            Console.WriteLine("Please enter the Radius of the circle and I will calculate it's Circumference and Area: ");
            radius = Convert.ToDouble(Console.ReadLine());
            radiusSquared = (radius * radius);
            area = Math.PI * (radiusSquared);
            circumference = 2 * (Math.PI * radius);
            Console.WriteLine($"The Area of your circle is:  {area}");
            Console.WriteLine($"The Circumference of your circle is:  {circumference}");

            Console.ReadLine();
           
        }
    }
}
