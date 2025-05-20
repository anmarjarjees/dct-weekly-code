// we can write anything here! 
// yes we can!
// Format Our CODE => CTRL + K, CTRK + D
namespace InputOutputMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // different data types in C#:
            // declaring different variables:
            string college = "Georgian";
            string course = "Data Centre Technologies";
            int weeks = 15; // whole number
            double avg = 60.00;
            // variable => camelCase => Pass Grade => passGrade
            double passGrade = 50.00;
            double age = 22;
            // in C#: we use " with string and ' with one character!
            char firstLetter = 'A'; // one character

            Console.WriteLine($"Our college is {college}. Our current course is {course}. We have {weeks} weeks. The minimum grade to pass any course is {passGrade} ");

            int a = 10;
            int b = 3;
            Console.WriteLine($"Total of a + b is ${a + b}");
            Console.WriteLine($"Addition: {a + b}"); // Adds a and b
            Console.WriteLine($"Subtraction: {a - b}"); // Subtracts b from a
            Console.WriteLine($"Multiplication: {a * b}"); // Multiplies a and b
            Console.WriteLine($"Division: {a / b}"); // Divides a by b (integer division)
            Console.WriteLine($"Modulus (Remainder): {a % b}"); // Gets the remainder of a divided by b

            // Creating a simple application1:
            // Finding the average by hard coding the grades!!!!
            // Grade => Number => 89.79 or 90 => double => accept whole/decimal number:
            double grade1 = 90; // hard coding the values!!!
            double grade2 = 80;
            // Notice that avg has been already declared before
            // we can reuse the same variable "avg":
            avg = (grade1 + grade2) / 2;
            // PEDMAS => Par.. Exp.. Div.. Mul... Add... Sub...
            Console.WriteLine($"The average of {grade1} and {grade2} is: {avg}");

            // Creating a simple application2:
            // Ask the user to enter their 2 assignments grades!
            // We will find the average of these two assignment:
            Console.WriteLine("Enter the grade of your first assignment");
            // double firstGrade = Console.ReadLine();
            // ?? => either the user input or "" if nothing is entered
            string firstGrade = Console.ReadLine() ?? ""; // 90 => "90"

            Console.WriteLine("Enter the grade of your second assignment");
            string secondGrade = Console.ReadLine() ?? ""; // 80 => "80"

            /*
             * Validation is IMPORTANT!
             * As programmers, we should check:
             * if the input is empty
             * if the input is not a number
             * we should display a warning message!
             * we need if condition to check/scan the user input
             */ 
            double assignAvg = (Convert.ToDouble(firstGrade) + Convert.ToDouble(secondGrade))/2;

            Console.WriteLine($"The average of first assignment of {firstGrade} and the second assignment of {secondGrade} is: {assignAvg}");

        }
    }
}
