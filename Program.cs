using System;
/*
 * User: Justin Hartman
 * Class: ISM 4300
 * Assignment: Deliverable Iterative Statement
 * Date: 9/12/2019
 */

namespace Deliverable9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // this asks for the users input
            Console.WriteLine("Hello, please enter an integer between 1 & 100 to execute a iterative statement");

            // try catch implemented to validate the users input.
            // wrong inputs will be marked as error

            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                // input is what the user chooses as their number
                // the input is then parsed

                
                // between 1 & 50 generate a For loop
                if ((number > 1) && (number <= 50))
                {
                    Console.WriteLine("Executing a For Loop");
                    

                    for (int i = 1; i < number; i++)
                    {
                        Console.WriteLine("You have entered " + input + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                    // allows user to exit
                }
                // between 51 & 100 returns a Do while loop subtracting a number
                else if ((number >= 51) && (number < 100))
                {
                    Console.WriteLine("Executing a Do While Loop");
     

                    do
                    {
                        Console.WriteLine("You have entered " + input + ". This is the current integer value in the loop: " + number );
                        number--;

                    }
                    while (number > 0);
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }

            }
            // catches an error and displys this message
            catch
            {
                Console.WriteLine("This is an error");
            } // end of try catch 

        } // program end
    }
}
