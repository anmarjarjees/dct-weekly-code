// One line of comment!
// I can write anything I like in the comment line!!!!
namespace InputOutputBasics
{
    internal class Program
    {
        // Main => is the main method to run our application!
        static void Main(string[] args)
        {
            /*
             * Console => the "Console" object 
             * has a method => WriteLine => to output
             */
            // Console.WriteLine("Hello, World!");
            // Console.ReadLine();
            Console.WriteLine("Enter your subject:");
            // wait wait, could you please let enter my subject name?
            // saving the project name to a container => variable:
            /*
             * Every Variable has a data type!
             * C# => list of data types:
             * Alex => string
             * 12 => integer => int
             * 17.5 => double
             */
            string subject = Console.ReadLine(); // DCT

            // Concatenation!!!!!!!!!!!!!!!!!!
            Console.WriteLine("Your subject is " + subject);
            // Your subject is DCT

            Console.WriteLine("Enter your college name:");
            string college = Console.ReadLine();
            // NOTE: We will ignore the warning about "Console.ReadLine()" for now

            Console.WriteLine("So, your college name is: " + college);

            Console.WriteLine("What's your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Your age is " + age);
        }
    }
}