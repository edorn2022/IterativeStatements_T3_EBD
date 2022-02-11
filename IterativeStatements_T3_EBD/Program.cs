using System;

namespace T3_InterativeStatements_EBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user
            Console.WriteLine("Please enter in a number between 5 and 25 for iteration.");

            //read line
            string userInput = Console.ReadLine();

            try
            {
                //parsing userInput
                int incrementValue = int.Parse(userInput);
                //runs check on value (failure redirects to catch message and ends program
                if (incrementValue >= 5 && incrementValue <= 25)
                {
                    //set value for usd and cad
                    double USD = 0;
                    double CAD = 0;
                    //create a var to archive the original increment value (forgot the logic to do this in a simpler way but I know it exists)
                    int originalInc = incrementValue;
                    //create a constant for the conversion
                    const double convert = .792367;
                    //Header for "table"
                    Console.WriteLine("CAD" + "     " + "USD");
                    while (CAD <= 200)
                    {
                        Console.WriteLine(CAD.ToString() + "     " + USD.ToString());
                        USD = CAD * convert;
                        CAD = incrementValue;
                        incrementValue += originalInc;

                    }
                }
                else
                {
                    Console.WriteLine("Please pick a whole number between 5 and 25");
                }
            }
            catch
            {

                Console.WriteLine("Invalid input, please restart and enter an increment number between 5 and 25 that is a whole number");

            }
        }
    }
}