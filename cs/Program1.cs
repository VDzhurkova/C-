using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Please enter number:");
                int input = Convert.ToInt32(Console.ReadLine());
                numbers[i] = input;
            }
            int total = 0;

            for (int i = 0; i < numbers.Length; i++) {
                total += numbers[i];
                
            }

            double result = ((double)total / 2);
            Console.WriteLine("The average of the input numbers is {0}", result);
        }
    }
}
