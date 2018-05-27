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
            string[] country = {"Thailand ","Laos","Singapore","Cambodia","Indonesia"};
            for (int i = 0;  i < 3;  i++) 
            {
                Console.WriteLine(country[i]);
            }
            Console.WriteLine("-------");
            foreach (string data in country)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
