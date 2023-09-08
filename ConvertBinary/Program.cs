/* Krysten Guerrero
 * RIT student
 * 9/7/23
 * 
 * THIS PROGRAM WAS MADE TO HELP ME FAMILIARIZE MYSELF WITH C#
 * THIS PROGRAM WAS NOT MADE TO CONVERT LARGE NUMBERS
 */

using System.Runtime.CompilerServices;

namespace ConvertBinary
{
    internal class Program
    {
        //creates all variables needed for this program
        static private string optionInput = "";
        static private int numberToConvert = 0;

        static void Main(string[] args)
        {
            //warning on program limits
            Console.WriteLine("Please note that the highest number this program can convert atm is 127");
            Console.WriteLine("Please note that this program cannot convert negative numbers yet");
            Console.WriteLine();

            //ask for user input
            Console.WriteLine("Type 1 to convert decimal to binary");
            Console.WriteLine("Type 2 to convert binary to decimal");
            optionInput = Console.ReadLine();
            Console.WriteLine();

            //make sure program doesn't break!!
            if (optionInput.Equals("1"))
            {
                Console.WriteLine("What decimal number would you like to convert?");
                numberToConvert = inputCheck(Console.ReadLine());
                DecimalToBinary();
            }
            else if (optionInput.Equals("2"))
            {
                BinaryToDecimal();
            }
            else
            {
                Console.WriteLine("That is not an option");

                /* HEY HEY
                 * FIX THIS LATER
                 * NEED TO MAKE PROGRAM NOT RESTART ANYTIME SOMEONE INPUTS SMTH WRONG
                 * */
                Console.WriteLine("Press any key to restart program");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void DecimalToBinary()
        {
            
        }

        static void BinaryToDecimal()
        {
            
        }

        static int inputCheck(string input)
        {
            //makes sure system doesn't break if you input smth that doesn't work in the program!
            if(int.TryParse(input, out numberToConvert) == true)
                if(numberToConvert < 128)
                {
                    Console.WriteLine(numberToConvert);
                    return numberToConvert;
                }
            Console.WriteLine();
            Console.WriteLine("That is not a valid input");
            return 0;
        }
    }
}