using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAutors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> library = new Dictionary<string, string>();
            library.Add("The Firm", "John Grisham" );
            library.Add("A Time to Kill", "John Grisham");
            library.Add("It", "Stephen King");
            library.Add("The Shining","Stephen King");

            Console.WriteLine("Please enter A to add to the list of books"+Console.Out.NewLine+ " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
            string input = Console.ReadLine().ToLower();

            while (input != "x") {

                switch (input) {
                    case "a":
                        addToDict(library);
                        Console.WriteLine("Please enter A to add to the list of books" + Console.Out.NewLine + " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "d":
                        deleteFromDict(library);
                        Console.WriteLine("Please enter A to add to the list of books" + Console.Out.NewLine + " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "s":
                        sortDict(library);
                        Console.WriteLine("Please enter A to add to the list of books" + Console.Out.NewLine + " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "v":
                        displayDict(library);
                        Console.WriteLine("Please enter A to add to the list of books" + Console.Out.NewLine + " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
                        input = Console.ReadLine().ToLower();
                        break;
                    case "f":
                       findBookByAutor(library);
                        Console.WriteLine("Please enter A to add to the list of books" + Console.Out.NewLine + " D to delete from the list" + Console.Out.NewLine + " S to sort it" + Console.Out.NewLine + " V to display it" + Console.Out.NewLine + "F to find Autor's book" + Console.Out.NewLine + "X to exit");
                        input = Console.ReadLine().ToLower();
                        break;
                    default: break;

                }
            }



        }

        public static void deleteFromDict(Dictionary<string, string> dict)
        {
            Console.WriteLine("Please enter Book name:");
            string key = Console.ReadLine();
            dict.Remove(key);
        }

        public static void addToDict(Dictionary<string, string> dict)
        {
            Console.WriteLine("Please enter Book name:");
            string key = Console.ReadLine();
            Console.WriteLine("Please enter Autor:");
            string value = Console.ReadLine();
            dict.Add(key, value);

        }

        public static void sortDict(Dictionary<string, string> dict)
        {
            dict.OrderByDescending(pair => pair.Value);

        }

        public static void displayDict(Dictionary<string, string> dict)
        {
            Console.WriteLine("All entries are:" + Console.Out.NewLine);
            foreach (KeyValuePair<string, string> kv in dict)
            {

                Console.WriteLine("{0},{1}", kv.Key, kv.Value);
            }
        }
        public static void findBookByAutor(Dictionary<string, string> dict)
        {
            Console.WriteLine("Please enter a key:");
            string input = Console.ReadLine().ToLower();

            foreach (KeyValuePair<string, string> kv in dict)
            {
                if (((kv.Value).ToLower().Contains(input) == true) || ((kv.Value).ToLower() == input))
                {
                    Console.WriteLine("The Autor of {0} is {1}", kv.Key, kv.Value);
                }

            }
        }

    }
}
