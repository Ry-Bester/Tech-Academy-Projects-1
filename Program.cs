using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydrill
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                string[] str1 = { "cat", "dog", "monkey", "donkey", "rat" };
                Console.WriteLine("Pick a number between 0-4");
                int str2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(str1[str2]);
                Console.ReadLine();

                int[] num1 = { 20, 45, 23, 17, 16 };
                Console.WriteLine("Pick a number between 0-4");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1[num2]);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("please choose a number between 1-4");
            }
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(22);
            numbers.Add(33);
            numbers.Add(44);
            numbers.Add(55);
            Console.WriteLine("Please choose a number0-4");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numbers[num3]);
            Console.ReadLine();

        }
        
    }
}
