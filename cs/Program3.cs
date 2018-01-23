using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            int input = 0;
            try
            {
                for (int i = 0; i <= numbers.Length; i++)
                {
                    Console.WriteLine("Please enter value:");
                    try {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e){
                        Console.WriteLine(e.Message);
                    }
                    numbers[i] = input;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}
