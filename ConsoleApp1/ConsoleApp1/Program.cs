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
            Console.WriteLine(calculate());
            sayHelloWorld();
            Console.ReadLine();
        }
        private static void sayHelloWorld()
        {
            Console.WriteLine("Hello ");
        }
        private static int calculate()
        {
            int a = 10;
            int b = 20;
            int sum = a * b;
            return sum;
        }
    }
}
