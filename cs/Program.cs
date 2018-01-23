using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5X5Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5] { {1,2,3,4,5 }, {1,2,3,4,5 }, {1,2,3,4,5 }, { 1,2,3,4,5}, { 1,2,3,4,5} };

            int rowTotal = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) {

                    rowTotal += array[i, j];
                }
            }

            int columnTotal = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    columnTotal += array[j, i];
                }
            }

            int grandTotal = rowTotal + columnTotal;

            Console.WriteLine("The sum od the array rows is {0}" +Console.Out.NewLine+ "The sum of the array columns is {1}" +Console.Out.NewLine+ "The total sum is {2}", rowTotal,columnTotal, grandTotal);


        }
    }
}
