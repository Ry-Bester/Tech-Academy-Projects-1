﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int wei = Convert.ToInt32(Console.ReadLine());

            if (wei >= 50) 
            {
                Console.WriteLine("Package is to heavy to be shipped");
                return;
            }
            
            else if (wei < 50)
            { 
                Console.WriteLine("Weight Accepted");
            }
            
            Console.WriteLine("Please enter the package height.");
            int hei = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width.");
            int wid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length.");
            int len = Convert.ToInt32(Console.ReadLine());
            int Dim = hei * len * wid;
            if (Dim >= 50)

            {
                Console.WriteLine("Package is to big to be shiped.");
                Console.ReadLine();
                return;
                
            }
            
            else if (Dim < 50) 

            {  
                Console.WriteLine("Dimensions Accepted!");

            }

            int total = Dim * wei / 100;
            Console.WriteLine("Your estimated total for shipping this package is:  $" + total);
            Console.ReadLine();













        }
    }
}
