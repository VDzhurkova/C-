using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1, input2;
            char input3;
            double output = 0;

            Console.WriteLine("Enter the first number:");
            input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the sign:");
            input3 = Convert.ToChar(Console.ReadLine());

            switch (input3) {

                case '+':
                    output = addNumbers(input1,input2);
                    break;
                case '-':
                    output = subNumbers(input1, input2);
                    break;
                case '*':
                    output = mulNumbers(input1, input2);
                    break;
                case '/':
                    output = divNumbers(input1, input2);
                    break;
                default: break;
            }
            Console.WriteLine(output);
        }

        public static double addNumbers(double firstNum, double secondNum) {
            return firstNum + secondNum;
        }

        public static double subNumbers(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public static double mulNumbers(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public static double divNumbers(double firstNum, double secondNum)
        {
            double result = 0;
            if (secondNum == 0) {

                Console.WriteLine("Please enter number different than NULL");
                secondNum = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}
