using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {



        public static void Main()
        {
            int enteredValue = 0;
            int[] correctIncorrectValues = new int[2];
            correctIncorrectValues[0] = 0;
            correctIncorrectValues[1] = 0;
            string score = "Values enetred: Correct: {0} \t Incorrect: {1}.";
            Console.WriteLine("Enter an integer number. Correct valus are from 0 to 10: \n To Exit press 'CTRL+C'");
            Console.WriteLine();
            Console.WriteLine(score, correctIncorrectValues[0], correctIncorrectValues[1]);

           // Console.Write("To Exit enter '+'.");

            do
            {
                int enteredNumber;
                
                try 
                {
                    enteredValue = Convert.ToInt16(Console.ReadLine());
                    enteredNumber = Convert.ToInt16(enteredValue);
                    if (enteredNumber >= 0 && enteredValue <= 10)
                    {
                        Console.WriteLine("You entered a correct number!");
                        correctIncorrectValues[0] = correctIncorrectValues[0] + 1;
                        Console.WriteLine(score, correctIncorrectValues[0], correctIncorrectValues[1]);
                    }
                    else 
                    {
                        Console.WriteLine("You entered not correct number!");
                        correctIncorrectValues[1] = correctIncorrectValues[1] + 1;
                        Console.WriteLine(score, correctIncorrectValues[0], correctIncorrectValues[1]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered not a number or not integer number!");
                    correctIncorrectValues[1] = correctIncorrectValues[1] + 1;
                    enteredNumber = Char.MinValue;
                    Console.WriteLine(score, correctIncorrectValues[0], correctIncorrectValues[1]);
                }

            }
            while (true);

        

        }

    }
}
