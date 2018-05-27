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
            string[] Country = {"Name","LastName","Salary"};
            Console.WriteLine("Enter your name");
            Country[0] = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            Country[1] = Console.ReadLine();
            Console.WriteLine("Enter your Sarary");
            Country[2] = Console.ReadLine();
            Console.WriteLine(Country[0]);
            Console.WriteLine(Country[1]);
            Console.WriteLine(Country[2]);
            Console.ReadLine();
            
        }
    }
}
