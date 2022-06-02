// Aiden McLeod
// ICS2O-Unit5-06-CSharp
// June 1 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int numberOne;
        int numberTwo;
        int timesRan;
        int result = 0;

        Console.WriteLine("Enter the first number:");
        while (!int.TryParse(Console.ReadLine(), out numberOne))
        {
            Console.WriteLine("Error: This isn't an integer.");
            Environment.Exit(0);
        }
        Console.Clear();
        Console.WriteLine("Enter the second number:");
        while (!int.TryParse(Console.ReadLine(), out numberTwo))
        {
            Console.WriteLine("Error: This isn't an integer.");
            Environment.Exit(0);
        }
        timesRan = numberTwo;
        if (numberOne != 0 && numberTwo >= 0)
        {
            while (timesRan > 0)
            {
                // Calculation for + or - times + numbers
                result = result + numberOne;
                timesRan = timesRan - 1;
            }
        }
        else if (numberTwo < 0)
        {
            while (timesRan != 0)
            {
                // Calculation for + or - times - numbers
                result = result - numberOne;
                timesRan = timesRan + 1;
            }
        }
        Console.Clear();
        Console.WriteLine("The result of " + numberOne + " × " + numberTwo + " is " + result);
        Console.WriteLine("\nFinished.");
    }
}