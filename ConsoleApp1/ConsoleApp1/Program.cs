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
            int score = int.Parse(Console.ReadLine()) ;
            if( score >=80 )
            {
                Console.WriteLine("A"); 
            }
            else
            {
                if( score >= 70)
                    Console.WriteLine("B");
                if( score >= 60 && score <=69)
                    Console.WriteLine("C");
                if( score >= 50 && score <= 59)
                    Console.WriteLine("D");
                else
                {
                    Console.WriteLine("F");
                }
            }            

            Console.ReadLine();
        }
    }
}
