using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("X + Y = " + (x + y));
            Console.WriteLine("X - Y = " + (x - y));
            Console.WriteLine("X * Y = " + (x * y));
            Console.WriteLine("X / Y = " + (x / y));
            Console.ReadLine();
        }
    }
}
