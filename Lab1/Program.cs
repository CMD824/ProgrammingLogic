using System;

class Program
{
    /*
     * Name: [Your Name]
     * Title: IT-1050 - Lab 1
     * How To: GitHub, CodeSpaces (IDE), and Submitting Your Labs
     */

    static void Main(string[] args)
    {
        // Step 2: Basic Output
        Console.WriteLine("My Name");
        Console.WriteLine("IT-1050 - Lab 1");

        // Step 3: Declare and Use Variables
        int favoriteNumber = 42;
        string favoriteLanguage = "C#";
        double programsWritten = 5.0;
        bool hasProgrammingExperience = true;

        Console.WriteLine("My favorite number is " + favoriteNumber);
        Console.WriteLine("My favorite programming language is " + favoriteLanguage);
        Console.WriteLine("Number of programs I've written: " + programsWritten);
        Console.WriteLine("Do I have programming experience? " + hasProgrammingExperience);

        // Step 4: Use Constants
        const string schoolName = "Your School Name";
        Console.WriteLine("My school is " + schoolName);

        // Step 5: Type Casting
        double decimalValue = 9.78;
        int castToInt = (int)decimalValue;
        string intToString = Convert.ToString(5);
        string boolToString = Convert.ToString(true);

        Console.WriteLine("double: " + decimalValue);
        Console.WriteLine("double cast to int: " + castToInt);
        Console.WriteLine("int converted to string: " + intToString);
        Console.WriteLine("bool converted to string: " + boolToString);

        // Step 6: User Input and Type Conversion
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();

        Console.WriteLine("Please enter your age:");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ", you are " + userAge + " years old!");

        // Step 7: Arithmetic Operators
        int num1 = 20;
        int num2 = 4;

        int addition = num1 + 10;
        int subtraction = num1 - 2;
        int multiplication = num1 * 3;
        int division = num1 / 2;
        int modulus = num1 % 2;

        Console.WriteLine("Addition result (num1 + 10): " + addition);
        Console.WriteLine("Subtraction result (num1 - 2): " + subtraction);
        Console.WriteLine("Multiplication result (num1 * 3): " + multiplication);
        Console.WriteLine("Division result (num1 / 2): " + division);
        Console.WriteLine("Modulus result (num1 % 2): " + modulus);

        // Step 8: Floating Point Precision
        float floatValue = 1.123456789f;
        double doubleValue = 1.123456789;

        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Notice: Double has more precision than float");

        // Step 9: Increment and Decrement
        int counter = 10;
        Console.WriteLine("Initial value: " + counter);

        counter++;
        Console.WriteLine("After increment (++): " + counter);

        counter--;
        Console.WriteLine("After decrement (--): " + counter);
    }
}
