namespace SwitchDemoPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // more examples about Switch Statement
            double avg = 50;
            /*
             * if the avg is greater than or equal to 80 => Well Done
             * - avg >= 80 => Well Done
             * - avg >= 70 => Good Job
             * - else less than 70 => "Never give up! You can try again" 
             */

            Console.WriteLine("IF-ELSE Example:\n");
            // NOTE: \n to add a new line
            if (avg >= 80)
            {
                // type cw then tab...
                // NOTE: No need for "System" as it's already in use (using/imported)
                System.Console.WriteLine("Well Done!");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Never give up! You can try again");
            }

            Console.WriteLine("\nSWITCH Example:\n");
            // Switch:
            switch (avg)
            {
                case < 50:
                    Console.WriteLine($"Your average {avg}; too low.");
                    break;
                case > 80.0:
                    Console.WriteLine($"Your average {avg}; too high.");
                    break;
                case > 70:
                    Console.WriteLine($"Your average {avg}; good.");
                    break;
                case >= 60:
                    Console.WriteLine($"Your average {avg}; Not bad.");
                    break;
                case >= 50:
                    Console.WriteLine($"Your average {avg}; Just Passing.");
                    break;
                default:
                    Console.WriteLine($"Invalid {avg} value!");
                    break;
            }
        }
    } // class
}