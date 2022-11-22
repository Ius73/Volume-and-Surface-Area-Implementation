using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_and_Surface_Area_Implementation
{
    internal class Program
    {
        static void cube_volume_area(double x, double y, double z)
        {
            double result;
            result = x * y * z;
            Console.WriteLine($"the volume of the cube is {result}m");
            result = ((x * y) * 2) + ((x * z) * 2) + ((z * y) * 2);
            Console.WriteLine($"the volume of the cube is {result}m");
        }
        static void sphere_volume_area(double r)
        {
            double result;
            const double pi = 3.14159265359;
            result = (4 / 3) * pi * (Math.Pow(r, 3));
            Console.WriteLine($"the volume of the sphere is {result}m");
            result = 4 * pi * (Math.Pow(r, 2));
            Console.WriteLine($"the surface are of the sphere is {result}m");
        }
        static char check_continue()
        {
            char con;
            Console.Write("do you want to continue Y/N: ");
            con = Convert.ToChar(Console.ReadLine());
            return con;
        }
        static void Main(string[] args)
        {
            char user_shape;
            double x;
            double y;
            double z;
            double r;
            int counter = 0;
            while(true)
            {
                Console.WriteLine("insert: ");
                Console.WriteLine("C for Cube");
                Console.WriteLine("S for Sphere");
                Console.WriteLine("E for Exit");
                user_shape = Convert.ToChar(Console.ReadLine());
                if (user_shape == 'C' || user_shape == 'c')
                {
                    Console.Write("insert the length of x: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("insert the Length of y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("insert the Length of z: ");
                    z = Convert.ToDouble(Console.ReadLine());
                    cube_volume_area(x, y, z);
                    counter++;
                }
                else if (user_shape == 'S' || user_shape == 's')
                {
                    Console.Write("insert the radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    sphere_volume_area(r);
                    counter++;
                }
                else if (user_shape == 'E' || user_shape == 'e')
                {
                    break;
                }
                else
                {
                    Console.Write("error,");
                    continue;
                }
                if(counter == 3)
                {
                    char c = check_continue();
                    if (c == 'Y' || c == 'y')
                    {
                        counter = 0;
                    }
                    else if (c == 'N' || c == 'n')
                    {
                        break;
                    }
                    else
                    {
                        check_continue();
                    }
                }
            }
        }
    }
}
