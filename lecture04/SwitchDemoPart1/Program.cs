// our project name is "ControlFlowAndCollections"
namespace SwitchDemoPart1
{
    internal class Program
    {
        // Main method => is the entry point to run our application
        static void Main(string[] args)
        {
            // Switch Statement:
            // Prompt the user to enter a number between 1 and 5
            Console.Write("Enter a number from 1 to 5: ");

            // Review: we must always specify the data type for any new variable:
            string input = Console.ReadLine() ?? ""; // 5 => "5"

            // we are expecting the user to input 1 to 5?
            // if the user inputs abc!
            /*
             * we can ask C# to try parsing the input to an integer number
             * we are asking C# to try converting the "5" as a string to 5 as an integer
             * 
             * int.TryParse():
             * - int.TryParse("5"): True (it's a numeric value)
             * - int.TryParse("abc"): False (it's a numeric value)
             */
            // bool (boolean) => True or False
            bool isValidInt = int.TryParse(input, out int number);
            /*
             * if the boolean variable "isValidInt" is True => the input is numeric
             * otherwise the input is not a numeric value
             */
            if (isValidInt) // true
            {
                // Way1:
                Console.WriteLine("You entered the number: " + number);
                // Way2:
                Console.WriteLine($"You entered the number: {number}");
                // Way3:
                Console.WriteLine("You entered the number: {0}", number);
            }
            else // false
            {
                Console.WriteLine("That wasn't a valid number.");
                // strop our Main method here
                // terminate the Main method 
                // return to our application
                return; // exit the Main method
            }

            // if statement:
            if (number == 1)
            {
                Console.WriteLine("You entered ONE!");
            }
            else if (number == 2)
            {
                Console.WriteLine("You entered TWO.");
            }
            else if (number == 3)
            {
                Console.WriteLine("You entered THREE.");
            }
            else if (number == 4)
            {
                Console.WriteLine("You entered FOUR.");
            }
            else if (number == 5)
            {
                Console.WriteLine("You entered FIVE.");
            }
            else
            {
                Console.WriteLine("You entered a number outside the 1-5 range.");
            }

            // Switch Statement Syntax:
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered ONE!");
                    // every case must have break:
                    break; // to stop the switch statement
                case 2:
                    Console.WriteLine("You entered TWO.");
                    break; // to stop the switch statement
                case 3:
                    Console.WriteLine("You entered THREE.");
                    break;
                case 4:
                    Console.WriteLine("You entered FOUR.");
                    break;
                case 5:
                    Console.WriteLine("You entered FIVE.");
                    break;
                default:
                    Console.WriteLine("You entered a number outside the 1-5 range.");
                    break;
            } // switch
        } // end Main
    } // class
} // namespace
