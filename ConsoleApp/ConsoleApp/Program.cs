using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "jayden";

            Console.Title = "Startup.exe";

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Starting setup...");
            Console.WriteLine("Retrieving framework information...");
            Console.WriteLine("Hello " + name);
            Console.Read();

            string enter = Console.ReadLine();

            if (enter = "Help" || enter = "HELP")
            {
                Console.WriteLine("tutjyj");
            }
        }
    }
}
