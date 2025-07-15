// the namespace "MethodMoreTopics" is the Project Folder name
namespace MethodMoreTopics
{
    internal class Program
    {
        /* 
        Working with Methods:
        *********************
        - Method => A function that belongs to a class in C#
        - Function => A general programming term for a block of reusable code
        functions do actions :-)
       */

        // Main() Method => given to us by C# Compiler
        // static void Main(string[] args)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Calling our methods (inside the Main method):
            double exam1 = 78.67;
            double exam2 = 81.56;
            // double average = (exam1 + exam2) / 2;

            // arguments => what we pass to the methods when we call/invoke them:
            // arguments: exam1, exam2
            double average1 = GetAverage(exam1, exam2);
            Console.WriteLine("The average of 2 exams is " + average1);

            double average2 = GetAverage(80, 75, 68.5, 90);
            Console.WriteLine("The average of 4 quizzes is " + average2);

            double lb = 35;
            // argument => lb
            Console.WriteLine("The value in kg " + ConvertLBtoKG(lb));
        } // end Main()

        // adding more methods :-)
        /*
         * Problem:
         * Average for 2 numeric values:
         * 2 exams midterm and final
         * this methods needs 2 numeric variables! 
         * 
         * In methods => the passing variables => parameters
         * this method accepts two parameters (are just variable):
         * - num1: is a variable of type "double" => accepts int or decimal
         * - num2: the same :-)
         * 
         * we need to specify the return type (if there is any return)
         * or use the keyword "void" if the method has no "return"
         */

        // This method can be used for our two exams: midterm and final
        // This method can be used for our two assignments: midterm and final
        public static double GetAverage(double num1, double num2)
        {
            // Console.WriteLine((num1 + num2) / 2);
            return (num1 + num2) / 2;
        } // end GetAverage()

        /*
         * A PIE :-)
         * A => Abstraction
         * P => Polymorphism (Method Overloading & Method Overriding)
         * I => Inheritance
         * E => Encapsulation 
         * 
         * Polymorphism: 
         * Has Two types:
         * - Method Overloading (in our current example)
         * - Method Overriding (next...)
         * 
         * Method Overloading: 
         * *******************
         * We can have multiple methods with the same name but different parameter:
         * - Different Set Of Parameters
         * - Different Data Types
         */

        // We need a similar method but for our 4 quizzes!
        // instead of having 2 "parameters", we need 4 "parameters"
        static double GetAverage(double num1, double num2, double num3, double num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        } // end GetAverage()

        // we can add more...
        // method => Converting LB to KG
        // needs only one parameter (variable) => the LB values
        // "parameters" => what we are passing to the methods when created
        // we can add "public" to make it publicly available (outside the class)
        // in this example no difference 
        public static double ConvertLBtoKG(double lb)
        {
            // Formula: for an approximate result, divide the mass value by 2.205

            // in two lines:
            double kg = lb / 2.205;
            return kg;

            // or just in one line:
            // return lb / 2.205;
        }
    } // end class
} // end namespace
