using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string Dui = (Console.ReadLine());            
            Console.WriteLine("How many speeding tickets do you have?");
            int tic = Convert.ToInt32(Console.ReadLine());
            bool CD = (age > 15 && Dui == false && tic < 3);
            Console.WriteLine("CD");
            Console.ReadLine();





        }
    }
}
