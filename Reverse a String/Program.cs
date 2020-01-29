using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            bool appIsRunning = true;
            while (appIsRunning = true)
            {
                Console.WriteLine("Enter a string: ");
                string input = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Reversed string: ");
                Console.WriteLine(ReverseString(input));
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static string ReverseString(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                string msg = "No string entered";
                return msg;
            }
            string output = "";
            for (int i = input.Length; i > 0; i--)
            {
                output += input[i-1];
            }
            return output;
        }
    }
}
