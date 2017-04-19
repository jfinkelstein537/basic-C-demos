using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userValue;
            do
            {
                Console.WriteLine("Whatever you type, this program will return the same text. \nIf you type 'Exit', it will close.\n");
                userValue = Console.ReadLine();
                Console.WriteLine("\n" + "You wrote: " + userValue +"\n");
            }
            while (userValue != "Exit");   
        }
    }
}