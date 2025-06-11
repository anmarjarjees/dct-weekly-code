namespace Part1Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays (List)");

            int myLuckyNumber = 7;
            Console.WriteLine(myLuckyNumber); // 7

            // But what if I have 5 lucky numbers?
            int myLuckyNumber1 = 9;
            int myLuckyNumber2 = 3;
            int myLuckyNumber3 = 10;
            int myLuckyNumber4 = 25;
            int myLuckyNumber5 = 30;

            // luckyNumbers is an array => []
            // we declared an array with their values
            int[] luckyNumbers = { 9, 3, 10, 25, 30 };
            Console.WriteLine(luckyNumbers); // System.Int32[] => an array of integers

            /*
             * Array Rules:
             * ************
             * - Each element (value) => has its own unique index
             * - Arrays are 0 based indexed => first element has the index of 0
             * - The index values can be used to access any individual element
             * - we use the [] symbol for the index values
             */

            // Task: output/print the first lucky number => 9
            Console.WriteLine(luckyNumbers[0]); // 9

            // Task: output/print the second lucky number => 3
            Console.WriteLine(luckyNumbers[1]); // 3

            // More Examples:
            // Array of languages:
            // we declared and initialized their values
            string[] languages = { "Python", "Java", "C#", "JavaScript" };
            Console.WriteLine("We are studying " + languages[2]);

            // Array of students:
            // just declaring a new array of type "string" with 6 elements (students)
            string[] students = new string[6]; // 6 elements max - highest index = 5

            // Manually assign the names to each element (index) in the array:
            students[0] = "Alex Chow";
            students[1] = "Martin Smith";
            students[2] = "Sam Simpson";
            students[3] = "Sarah Grandson";
            students[4] = "Kate Wilson";
            students[5] = "Elena Chow";
            // add the 7th element:
            // students[6] = "James Dean"; // Error
            /*
             * System.IndexOutOfRangeException
             * Message=Index was outside the bounds of the array.
             * 
             * Exception => an error happening in the runtime
             */

            // 2D: => it's an array inside another array FYI :-)
            /*
             * Countries And Their Capital Cities:
             * Canada => Ottawa
             * USA => Washington
             * UK => London
             * Japan => Tokyo
             */
            string[,] countriesAndCapitals =
            {
                // every element is an array that contains 2 elements: Country, Capital
                // element of index 0 => { "Canada", "Ottawa"}
                { "Canada", "Ottawa"}, // index 0 => Canada and index 1 => Ottawa
                // element of index 1 => { "USA", "Washington"},
                { "USA", "Washington"},
                { "UK", "London" },
                { "Japan", "Tokyo" }
            };

            // Task: output "The capital of Canada is Ottawa"
            Console.WriteLine("The capital of Canada is " + countriesAndCapitals[0, 1]);

        } // Main
    } // class
} // namespace