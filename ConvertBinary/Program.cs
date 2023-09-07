/* Krysten Guerrero
 * RIT student
 * 9/7/23           */

using System.Runtime.CompilerServices;

namespace ConvertBinary
{
    internal class Program
    {
        //creates all variables needed for this program
        static private string userConvertInput = "", decimalNumber = "", binaryNumber = "";

        static void Main(string[] args)
        {
            //ask for user input
            Console.WriteLine("Type 1 to convert decimal to binary");
            Console.WriteLine("Type 2 to convert binary to decimal");
            userConvertInput = Console.ReadLine();

            //make sure program doesn't break!!
            if (userConvertInput.Equals("1"))
                DecimalToBinary();
            else if (userConvertInput.Equals("2"))
                BinaryToDecimal();
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
            int 
            Console.WriteLine("What decimal number would you like to convert?");
            Console.WriteLine("Please note that the highest number this program can convert atm is 63");
            Console.WriteLine("Please note that this program cannot convert negative numbers yet")
            decimalNumber = Console.ReadLine();


        }

        static void BinaryToDecimal()
        {

        }
    }
}