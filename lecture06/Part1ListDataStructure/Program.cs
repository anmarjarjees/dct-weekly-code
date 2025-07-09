namespace Part1ListDataStructure
{
    internal class Program
    {
        // method (function)
        // methods are just function inside a class
        // must contain => return type + method name + ( 0 or x number of parameters)
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure: List");
            // create an empty list of students: 
            // we can use the following classical way, long :-(
            // List<string> studentNames = new List<string>();
            // or using the shorthand way, shorter :-)
            List<string> studentNames = new ();
            // "studentNames" is an "object" of type "List"
            /*
            any object can have:
            - properties (characteristics in our real life)
            - methods (actions in our real life)
            */
            // using a method "Add()" => for adding elements
            // methods always have ()
            studentNames.Add("Alex Chow");
            studentNames.Add("Martin Smith");
            studentNames.Add("Sam Simpson");
            studentNames.Add("Sarah Grandson");
            studentNames.Add("Kate Wilson");
            studentNames.Add("Elena Chow");


            // total of students:
            // use a property named "count" => count number of element
            Console.WriteLine("Student Total: " + studentNames.Count);

            // using a loop to print all the names!
            int count = 1;
            foreach (string name in studentNames)
            {
                /*
                 * Student#1: Alex...
                 * Student#2: Sarah...
                 * etc...
                 */ 
                Console.WriteLine($"Student# {count}: {name}");
                count++;
                // you can check my main reference for more example
            }

            studentNames.Clear(); // clear my entire list!
           
        } // Main
    } // class
} // namespace
