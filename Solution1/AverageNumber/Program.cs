using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15, c = 20, d = 30;
            int rez = (a + b + c + d) / 4;
            Console.WriteLine($"The average number of {a},{b},{c},{d} is {rez}");
            Console.ReadLine();
        }
    }
}
