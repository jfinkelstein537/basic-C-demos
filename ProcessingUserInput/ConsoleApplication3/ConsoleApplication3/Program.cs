using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userValue;
            int i;
            do
            {
                Console.WriteLine("This program will tell you if a number is even or odd.\n" + "Type a number to see, or type 'Exit' to close.\n");
                userValue = Console.ReadLine();
                if (userValue != "Exit")
                {
                    i = int.Parse(userValue);
                    if (i % 2 == 0)
                    {
                        Console.Write("\nEntered number is even\n");
                    }
                    else
                    {
                        Console.Write("\nEntered number i odd\n");
                    }
                }
                Console.WriteLine("\n" + "You wrote: " + userValue + "\n");
            }
            while (userValue != "Exit");
        }

    }
}
