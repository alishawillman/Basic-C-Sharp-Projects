using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();

        Console.WriteLine("Have you ever had a DUI? Answer True or False.");
        string dui = Console.ReadLine();

        Console.WriteLine("How many speeding tickets do you have?");
        string tickets = Console.ReadLine();

        // Casting string to int
        int personAge = Convert.ToInt32(age);
        int personTickets = Convert.ToInt32(tickets);

        // Casting string to bool
        bool personDUI = bool.Parse(dui);


        Console.WriteLine("Is this person qualified for car insurance?");
        Console.ReadLine();
        bool qualified = (personAge >= 15 && personDUI == false && personTickets <= 3);
        Console.WriteLine(qualified);
        Console.ReadLine();
    }
}
