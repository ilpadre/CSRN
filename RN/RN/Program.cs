using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProcessInput();
        }

        private static void ProcessInput()
        {
            string input = string.Empty;
            do
            {
                DisplayMenu();
                input = GetInput();
                if (InputIsValid(input))
                {
                    Execute(input);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            } while (input.ToLower().ElementAt(0) != 'n');
        }

        private static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Convert number to Roman Numeral");
            Console.WriteLine("2. Convert Roman Numeral to number");
            Console.WriteLine("3. Exit program");
            Console.Write("Enter a 1, 2, or 3: ");
        }

        private static string GetInput()
        {
            return Console.ReadLine();
        }

        private static bool InputIsValid(string input)
        {
            bool isValid = false;
            switch (input)
            {
                case "1":
                case "2":
                case "3":
                    isValid = true;
                    break;
                default:
                    break;
            }

            return isValid;
        }

        private static void Execute(string input)
        {
            switch (input)
            {
                case "1":
                    ConvertNumberToRN();
                    break;
                case "2":
                    ConvertRNToNumber();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void ConvertNumberToRN()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number");
            var num = Console.ReadLine();
            var rn = RomanNumeral.ConvertToRN(Convert.ToInt32(num));
            Console.WriteLine( $"{num} = {rn}");
        }

        private static void ConvertRNToNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a Roman Numeral");
            var rn = Console.ReadLine();
            var num = RomanNumeral.ConvertFromRN(rn);
            Console.WriteLine($"{rn} = {num}");
        }
    }
}
