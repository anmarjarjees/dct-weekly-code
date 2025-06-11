namespace Part2Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");

            // iterate 5 times: 1 to 5
            // for loop:
            // i++ => just adding 1 
            // condition to keep iterating since i <= 5
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("For Loop Counter: " + i);
            }


            // while loop:
            // \n => a new line:
            Console.WriteLine("\nWhile Loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("While Loop Counter: " + j);
                j++; // we do need to increment the loop counter
                /*
                 * When j became 6 => the loop will stop => the condition is false
                 */
            }

            // do-while loop:
            Console.WriteLine("\nDo-While Loop:");
            int k = 1;
            do
            {
                Console.WriteLine("Loop Counter: " + k);
                k++;
            }
            while (k <= 5);

            // Finally: foreach:
            // Used with arrays, and lists
            Console.WriteLine("\nForeach Loop:");
            string[] printingColors = { "Cyan", "Magenta", "Yellow", "Black" };
            foreach (string color in printingColors)
            {
                Console.WriteLine("Color: " + color);
            }

            Console.WriteLine("\nFor Loop with Array:");
            // we can still use for, while, do-while with arrays:
            // the loop counter "i" will represent the index value of each element (color)
            // Arrays are 0 based index!
            for (int i = 0; i < printingColors.Length; i++)
            {
                Console.WriteLine(printingColors[i]);
            }
        } // Main()
    } // class
} // namespace

