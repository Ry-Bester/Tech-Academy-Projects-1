using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_drill_pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-25.");
            int number = Convert.ToInt32(Console.ReadLine());

            bool correct = number == 23;

            do
           
            {
                
                switch (number)

                {
                    case 1:
                        Console.WriteLine("you guessed one! but thats not the right one.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("you guessed 10! but thats not the right one.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 15:
                        Console.WriteLine("you guessed 15! but thats not the right one.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 23:
                        Console.WriteLine("you guessed 23. Great age right?! You got it");
                        correct = true;
                        break;

                    default:
                        Console.WriteLine("Nope sorry!");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                        

                }
            }
            while (!correct);
            Console.ReadLine();

        }
    }
}
