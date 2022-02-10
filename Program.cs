// Creater: Laura Warneke
// Date: 2/9/20222
// Border Provisioners currency conversion table, converts canadian dollars to us dollars
using System;

namespace Warneke_T3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input CAD increment value between 5 and 25
            Console.WriteLine("Enter a CAD increment integer value between 5 and 25:");

            // Use of try catch block to validate a numeric value between 5 and 25
            try
            {
                // Read input entered by user
                string input = Console.ReadLine();
                // Increment value variable to perform iterative statements
                int increment = int.Parse(input);
                int begCanadianDollar = 0;
                int maxCanadianDollar = 200;
                int canadianValue = 0;
                double dollarValue = 0;
                double currencyConverter = .792367;

                // If statement used to ensure value can be used
                if ((increment >= 5) && (increment <= 25))
                {
                    Console.WriteLine("CAD     US$");

                    // Create while loop for iterations
                    for (int i = 0; i < maxCanadianDollar; i += increment)
                    {
                        // Compute table values and round dollar value
                        canadianValue = begCanadianDollar += increment;
                        dollarValue = currencyConverter * canadianValue;
                        dollarValue = Math.Round(dollarValue, 2);
                        Console.WriteLine(canadianValue + "      " + dollarValue);

                    }
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                }
                // If user does not enter an integer or a number outside of 5 and 25
                else
                {
                    Console.WriteLine("Error: please enter an integer between 5 and 25");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
                }// end of try
            catch
            {
                Console.WriteLine("Error: please enter an integer between 5 and 25");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            } // end of catch


            }
            }



            



        }
    
