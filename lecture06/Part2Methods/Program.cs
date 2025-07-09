namespace Part2Methods
{
    internal class Program
    {
        /*
         * In python => function 
         * method => a function inside a class
         * In C#:
         * must have:
         * - return type
         * - method name
         * - () 
         * 
         * Example: Main() method:
         * - return type => void (this method has no return)
         * - method name => Main
         * - () => (string[] args) 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** Methods Demo **");

            // we cannot create our methods here (inside main)!
            // but we can only access/call our methods here:
            // calling our first method:
            SayHello("Aks Kumar");

            // calling our last method:
            // GetCircleArea => returns the area value
            // Print this returned value!
            Console.WriteLine("Circle Area: " + GetCircleArea(5));
        } // End of Main()

        /*
         * Our Methods:
         * - it must be created inside a class
         * - CANNOT be created inside Main()
         * 
         * Two Process/stages:
         * 1) Create our method
         * 2) Calling our method
         */

        // 1. Create a method so say hello + user name
        // Example: Hello Alex, Hello kate,....
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        // 2. Create a method to get the circle area
        // this methods:
        // - accepts => the radius value
        // - returns => the circle area
        // Formula => Area = PI * (radius * radius)
        /*
         * If the methods has a return type (not void),
         * we must use the keyword "return"
         */
        static double GetCircleArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

    } // End of class
} // End of namespace
