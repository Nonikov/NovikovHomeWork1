using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static int a, b, c, d;

        void InPut()
        {
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("C: ");
            c = Convert.ToInt32(Console.ReadLine());
        }

        int Discriminant()
        {
            d = b * b - 4 * a * c;
            return d;
        }

        void MethodOne()
        {
            double x1, x2;

            if (d > 0)
            {
                Console.WriteLine("Two roots");
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"Root one = {x1}");
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"Root two =  {x2}");
            }
            else if (d == 0)
            {
                Console.WriteLine("One root");
                x1 = -(b / (2 * a));
                Console.WriteLine($"Root = {x1}");
            }
            else if (d < 0)
            {
                Console.WriteLine("Without roots");
            }
        }
         void Start()
        {
            InPut();
            Discriminant();
            MethodOne();
        }


        static void Main(string[] args)
        {
            new Program().Start();

            Console.ReadLine();
        }
    }
}
