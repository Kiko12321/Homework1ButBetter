using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1:");
            int x= int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            int y = int.Parse(Console.ReadLine());
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"After swapping your first number is {x} and your second number is {y}");
            Console.ReadLine();
        }
    }
}
