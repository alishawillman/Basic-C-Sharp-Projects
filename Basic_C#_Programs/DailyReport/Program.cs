using System;


class Program
{
    static void Main()
    {
        //Printing The Tech Academy to the console
        Console.WriteLine("The Tech Academy");
        Console.ReadLine();

        //Printing Student Daily Report to the console
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();

        //Printing name to the console
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.ReadLine();

        //Printing course to the console
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.ReadLine();

        //Casting string to int 
        Console.WriteLine("What page number?");
        string page = Console.ReadLine();
        int pagenum = Convert.ToInt32(page);
        Console.ReadLine();

        //Casting string to bool
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        string help = "true";
        bool needsHelp = Convert.ToBoolean(help);
        Console.ReadLine();

        //Printing experiences to the console
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string experience = Console.ReadLine();
        Console.ReadLine();

        //Printing feedback to the console
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.ReadLine();

        //Casting string to decimal if 1/2 hour studied
        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        decimal hoursStudied = Convert.ToDecimal(hours);
        Console.ReadLine();

        //Printing thank you to the console
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();

        


    }
}

