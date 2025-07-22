// A PIE
namespace OOPBasics
{
    // This "class" will be used as Blueprint 
    /*
     * Class can have two members:
     * - Properties
     * - Methods
     */
    internal class Person
    {
        /*
         * Access Modifiers (Visibility Modifiers):
         * - Private => can only used inside the class itself
         * - Public => can be used inside/outside the class
         * - Protected => for later
         * - Internal => can be used within the same assembly 
         */
        // no Main() method in this class:
        // Class Fields:
        private string _name, _email, _address;
        private int _age;
        /*
         * C# Naming Convention:
         * any private field should start with "_"
         */

        // create public properties to access the private fields:
        // Properties can have: set and get
        // We create "public" properties to access "private" fields

        // template => AccessModifier ReturnedDataType FiledName { }
        // Property for the "_name" field:
        public string Name
        {
            // getting the person name:
            get { return _name; }
            // setting a new value to person name:
            set { _name = value; }
        }

        // Property for the "email" field:
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Property for the "age" field:
        /*
         * we don't have 0 age or negative age!!!
         */
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age! Must be non-negative value.");
                }
            }
        }

        /*
         * NOTE:
         * *****
         * if we need a custom constructor with x number of parameters
         * we have to create it by ourselves, we can create as much as we need!
         * 
         * we need this custom constructor to initialize the private fields:
         * - name
         * - email
         * - age
         * 
         * VERY IMPORTANT NOTE:
         * ********************
         * When we create a custom constructor that accept parameter(s),
         * This will destroy the default no parameter constructor
         * that we receive by default when we create a new class!
         * 
         * Solution:
         * if you still need the default constructor,
         * we need to explicitly create this default constructor again!
         */
        public Person()
        {
            // no need for any code!
        }

        public Person(string name, string email, int age)
        {
            // x = x ? In programming Ambiguous operation!
            this._name = name;
            this._email = email;
            this._age = age;
        }

        // Methods: same as with your second assignment :-)
        // Print the person information:
        public void PrintPersonInfo()
        {
            Console.WriteLine($"Name: {_name}\nAge: {_age}\nEmail: {_email}");
        }
    } // class
} // namespace
