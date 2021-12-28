using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.ReadLine();

        Console.WriteLine("Please enter package weight:");
        string weight = Console.ReadLine();

        // Casting string to int
        int weight1 = Convert.ToInt32(weight);

        //If statements
        string weightResult = weight1 > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Awesome, let's continue!";
        Console.WriteLine(weightResult);
        Console.ReadLine();

        Console.WriteLine("Please enter package weight:");
        string width = Console.ReadLine();

        Console.WriteLine("Please enter package height:");
        string height = Console.ReadLine();

        Console.WriteLine("Please enter package length:");
        string length = Console.ReadLine();

        // Casting string to int
        int width1 = Convert.ToInt32(width);
        int height1 = Convert.ToInt32(height);
        int length1 = Convert.ToInt32(length);

        // Dimensions
        int dimentions = width1 * height1 * length1 / 100;

        //If statements
        string shipResult = dimentions > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping is " +"$"+ dimentions + ", Thank you!";
        Console.WriteLine(shipResult);
        Console.ReadLine();
    }
}

