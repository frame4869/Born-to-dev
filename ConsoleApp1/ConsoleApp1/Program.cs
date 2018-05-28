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
            string[,] customers = {{ "name","address","mobile" }, { "name", "address", "mobile" }, { "name", "address", "mobile" }, { "name", "address", "mobile" }, { "name", "address", "mobile" } };

            Console.WriteLine("Enter your name");
            customers[0, 0] = Console.ReadLine();
            Console.WriteLine("Enter your address");
            customers[0, 1] = Console.ReadLine();
            Console.WriteLine("Enter your mobile");
            customers[0, 2] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter your name");
            customers[1, 0] = Console.ReadLine();
            Console.WriteLine("Enter your address");
            customers[1, 1] = Console.ReadLine();
            Console.WriteLine("Enter your mobile");
            customers[1, 2] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter your name");
            customers[2, 0] = Console.ReadLine();
            Console.WriteLine("Enter your address");
            customers[2, 1] = Console.ReadLine();
            Console.WriteLine("Enter your mobile");
            customers[2, 2] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter your name");
            customers[3, 0] = Console.ReadLine();
            Console.WriteLine("Enter your address");
            customers[3, 1] = Console.ReadLine();
            Console.WriteLine("Enter your mobile");
            customers[3, 2] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter your name");
            customers[4, 0] = Console.ReadLine();
            Console.WriteLine("Enter your address");
            customers[4, 1] = Console.ReadLine();
            Console.WriteLine("Enter your mobile");
            customers[4, 2] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Report>>");
            foreach (string data in customers)
            {
                
                Console.WriteLine(data);
            }
            //Console.WriteLine(customers[0, 0]);
            //Console.WriteLine(customers[0, 1]);
            //Console.WriteLine(customers[0, 2]);
            //Console.WriteLine(customers[0, 0]);
            Console.ReadLine();
        }
    }
}
