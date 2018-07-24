using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numers_drill_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int numO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number times 50 is"  + numO * 50);
            Console.WriteLine(" Please enter another number");
            int numT = Convert.ToInt32(Console.ReadLine());
            int numT2 = numT + 25;
            Console.WriteLine("Your number plus 25 is" + numT2);
            Console.WriteLine(" Please enter another number");
            int numth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 is" + numth / 12.5);
            Console.WriteLine(" Please enter another number");
            int numf = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = numf > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.WriteLine(" Please enter another number");
            int numfi = Convert.ToInt32(Console.ReadLine());
            int num5 = numf % 7;
            Console.WriteLine("the remainder is" + num5);
            Console.ReadLine();








        }
    }
}
