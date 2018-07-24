using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberdrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine(" Please type your hourly rate");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type how many hours a week you work");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine(" Please type your hourly rate");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type how many hours a week you work");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num12 = num1 * num2 *52 ;
            int num34 = num3 * num4 *52 ;
            Console.WriteLine("Person's 1 yearly income is" + num12);
            Console.WriteLine("Person's 2 yearly income is" + num34);
            Console.WriteLine("Does Person 1 make more then Person 2?");
            bool trueOrFalse = num12 > num34;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
















        }
    }
}
