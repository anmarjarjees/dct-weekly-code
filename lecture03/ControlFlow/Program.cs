namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // all your assignment answer goes here :-)

            /*
            Example1:
            Optimal temperature range: 18–27 C (64–80 F):​
            This is the recommended temperature range for data centres
            to operate efficiently and safely.
            */

            Console.WriteLine("Please Enter the current temperature in Fahrenheit:");
            // we can use "double" data type for the temp value
            string temp = Console.ReadLine(); // this method will always returns string!

            /*
             * We can use "Convert" class to convert string to integer or double values
             * OR:
             * using Parse()
             * 
             * The code below Convert.ToDouble() => returns a numeric value (double data type)
             */
            double temperature = Convert.ToDouble(temp); // Example: from "20.5" to 20.5

            // Optimal temperature range: 18–27 in Celsius OR 64–80 Fahrenheit:​
            /*
             * Logic:
             * If the temperature is 18 or more "AND" less than or equal to 27
             * 
             * Using "If Statement":
             * if (Our_Conditions) {
             * 
             * } else {
             * 
             * }
             * 
             * The temperature must be between this range (18-27)
             * Our_Condition: temperature >=18 AND temperature <=27
             * Optimal temperature range
             * 
             * In C# Logical Operators:
             * ************************
             * - AND => && => All conditions must be true
             * - OR => || => any condition must be true
             * - ! => NOT Operator
             */
            if (temperature >= 18 && temperature <= 27)
            {
                Console.WriteLine("Optimal temperature range");
            }
            else
            {
                Console.WriteLine("Not in the optimal temperature range!");
            }

            /*
             * What about an example of using "OR"?
             */
            // Example2: Toronto Public Library Access
            /*
             * Rule:
             * If you live OR work OR study in Toronto, library card is FREE
             * Otherwise, you must pay a membership fee.
             * This example shows how to use logical OR (||) to combine 3 conditions.
             * 
             * Ask the user 3 questions:
             * Do you live in Toronto? (yes/no):
             * Do you work in Toronto? (yes/no):
             * Do you study in Toronto? (yes/no):
             * At least one of them must be true to have a free library card
             */
            Console.WriteLine("Do you live in Toronto? (yes/no):");
            string live = Console.ReadLine()?.ToLower().Trim() ?? "";
            /*
             * ?? ""
             * if the user press Enter key without typing any value,
             * C# will use the empty string ""
             */

            Console.WriteLine("Do you work in Toronto? (yes/no):");
            string work = Console.ReadLine()?.ToLower().Trim() ?? "";

            Console.WriteLine("Do you study in Toronto? (yes/no):");
            string study = Console.ReadLine()?.ToLower().Trim() ?? "";

            /*
             * Logic:
             * if the user: live OR work OR study in Toronto:
             * Then they can have a free card
             * else they have to pay
             * 
             * The comparison operator AND the assignment operator:
             * assignment operator => int x = 10
             * comparison operator "Equal to" => x == y
             * 
             * HOTKEY => CTRL K, CTRL D => To format the code nicely :-)
             * 
             * work => Yes
             * "Yes" == "yes" => FALSE
             * "YES" == "yes" => FALSE
             * "YeS" == "yes" => FALSE
             * "YEs" == "yes" => FALSE
             * "yes" == "yes" => TRUE
             * "  yes " == "yes => FALSE
             * 
             * we need to always convert the user input into lowercase
             * to be on the safe side!
             */
            if (live == "yes" || work == "yes" || study == "yes")
            {
                Console.WriteLine("You are eligible for a FREE Toronto Public Library card!");
            }
            else
            {
                Console.WriteLine("You need to pay a non-resident membership fee.");
            }

            /*
            Comparison Operators:
            - ==  Equal to
            - !=  Not equal to
            - >   Greater than
            - <   Less than
            - >=  Greater than or equal to
            - <=  Less than or equal to

            Logical Operators:
            - &&  AND (both conditions must be true)
            - ||  OR (at least one condition must be true)
            - !   NOT (negates a condition)

            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
           */

            /*
             * TASK:
             * Relative Humidity (RH) 40%–60% 
             * (This range balances moisture levels in the air):​
             * Below 40% RH => the air is too dry
             * Above 60% RH => the air is too moist​
             * 
             * - Ask the user to input the humidity value
             * - Check if it's in the range 40 to 60
             */
        } // end Main
    } // end class
}
