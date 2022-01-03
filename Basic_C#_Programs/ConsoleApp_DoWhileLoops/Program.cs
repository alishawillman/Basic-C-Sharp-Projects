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


            Console.WriteLine("Now guess my favorite number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numGuessed = number == 8;

            //While loop
            while (!numGuessed)
            {
                switch (number)
                {
                    case 27:
                        Console.WriteLine("You guessed 27, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 107:
                        Console.WriteLine("You guessed 107, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 88:
                        Console.WriteLine("You guessed 88, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8! That's correct!");
                        isGuessed = true;
                        break;
                    case 322:
                        Console.WriteLine("You guessed 322, but that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.Read();
        }
    }
}
