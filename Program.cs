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
            double input1 = 0, input2 =0;
            char input3;
            double output = 0;

            Console.WriteLine("Enter the sign + to add, - to substract, * to multiply, / to divide, ^ to raise to a power, i to invert, s for sine, c for cosine and t for tangent:");
            input3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the first number:");
            input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Do you need to enter a second number (Y/N)");
            string answer = Console.ReadLine();

            if(answer == "Y") {
                Console.WriteLine("Enter the second number:");
                input2 = Convert.ToDouble(Console.ReadLine());
            }

            switch (input3)
            {

                case '+':
                    output = addNumbers(input1, input2);
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
                case '^':
                    output = powerNumbers(Convert.ToInt32(input1), Convert.ToInt32(input2));
                    break;
                case 'i':
                    output = invertNumbers(input1);
                    break;
                case 's':
                    output = Math.Sin(Convert.ToInt32(input1));
                    break;
                case 'c':
                    output = Math.Cos(Convert.ToInt32(input1)); ;
                    break;
                case 't':
                    output = Math.Tan(Convert.ToInt32(input1)); ;
                    break;
                default:
                    Console.WriteLine("Not a valid sign");
                    break;
            }
            Console.WriteLine(output);
        }

        public static double addNumbers(double firstNum, double secondNum)
        {
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
            if (secondNum == 0)
            {

                Console.WriteLine("Please enter number different than NULL");
                secondNum = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                result = firstNum / secondNum;
            }
            return result;
        }

        public static int powerNumbers(int value, int power) {

            return Convert.ToInt32(Math.Pow(value, power));
        }

        public static double invertNumbers(double number) {
            return (1 / number);
        }


    }
}
