using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionRenamer
{
    public static class ConsoleHelper
    {
        public static string GetParameterFromConsole(string message, string[] restrictedValues = null)
        {
            string input;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                input = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(input))
                {
                    WriteError("You should enter the value requested!");
                    Console.WriteLine();
                }
                else if (restrictedValues != null && !restrictedValues.Contains(input))
                {
                    WriteError("You should enter one of these values: " + string.Join(", ", restrictedValues));
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }

            return input;
        }

        public static void WriteError(string message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }
    }
}
