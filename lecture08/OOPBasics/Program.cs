namespace OOPBasics
{
    /*
     * Inside the class "Program":
     * we can call/run/execute the class "Person"
     * but we cannot access any private field/member
     */ 
    internal class Program
    {
        // any C# application must have a class with the Main()
        // Main() is the main entry point to run our application
        static void Main(string[] args)
        {
            Console.WriteLine("** Call and Run our Class 'Person' **");
            // creating our first person (object):
            // Name: Alex Chow - Age: 20 - Email: AlexChow@example.com
            // person1 is a variable => every variable must have a data type
            // person1 is of type "Person"
            /*
             * new Person() => calling a special method "Constructor"
             * - Every class is shipped with "Default Constructor"
             * - Default Constructor, free one :-):
             *   > A constructor that has NO parameters
             */
            Person person1 = new Person();

            // we call the public properties to set values for person1
            // we are calling the "setters" to set values
            // Property Template: objectName.PropertyName = Any Value
            person1.Name = "Alex Chow";
            person1.Age = 20;
            // person1.Email = string.Empty; // has no email (no string)
            person1.Email = "AlexChow@example.com";

            /*
             * - Q) Can't we create a new person and passing its values
             * at the same line when we use the "new" keyword
             * to call the constructor?
             * - Yes :-)
             * - How?
             * we need to add/create custom constructor(s) with parameters!
             * we can create another constructor with 3 parameters,
             * to accept these 3 arguments:
             * - Martin Smith
             * - m.smith@example.com
             * - 23
             */

            /*
             * Example:
             * we want to create a new person:
             * - Name: Martin Smith
             * - Email: m.smith@example.com
             * - age: 23
             */

            /*
             * Remember: 
             * We can have only one default constructor (No parameters) for free :-)
             * 
             * But below, we are calling a "Constructor" with parameters!
             * Do we have this type of constructors?
             * - if No => we have to created by ourselves
             */ 
            Person person2 = new Person("Martin Smith", "m.smith@example.com", 23);
            //Person person2 = new Person();
            // adding the value

            // calling the methods for our objects:
            // person1 and person2
            // Method Template: objectName.MethodName() 
            person1.PrintPersonInfo();
            Console.WriteLine("\n");
            person2.PrintPersonInfo();
        } // Main
    } // class

    /*
     * - Can we add here our custom class(es)?
     * - Yes, but not frequently used (not recommended practice!) 
     */ 
} // namespace
