using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyreport_drill
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(" What course are you on?");
           string course = Console.ReadLine();
            Console.WriteLine("What page number?");
           string pageNumber = Console.ReadLine();
            int pgnum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'. ");
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give Specifics");
            string posEx = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be Specific");
             string feedBa = Console.ReadLine();
            Console.WriteLine("How Many Hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrs = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers! An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
