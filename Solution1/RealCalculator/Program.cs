using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;

            Console.WriteLine("Choose between + or -");
            var znak= Console.ReadLine();
            switch (znak)
            {
                case "+":
                    Console.WriteLine(x+y);
                    break;
                case "-":
                    Console.WriteLine(x-y);
                    break;

                default:
                    Console.WriteLine("You made a boboo");
                    break;
            }
            Console.ReadLine();
        }
    }
}
