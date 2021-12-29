using System;


namespace ConsoleApp_DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color!");
            String color = Console.ReadLine();
            bool isGuessed = color == "red";

            // Do While Loop
            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red! That's correct!");
                        isGuessed = true;
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("That's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                }
            }
            //While loop 
            while (!isGuessed); //Shorthand for (isGuessed == false)
      

            Console.Read();
        }
    }
}
