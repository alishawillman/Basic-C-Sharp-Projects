using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.ReadLine();

        Console.WriteLine("Person 1");
        Console.ReadLine();

        Console.WriteLine("Hourly Rate?");
        string p1hr = Console.ReadLine();

        Console.WriteLine("Hours worked per week?");
        string p1hrswk = Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.ReadLine();

        Console.WriteLine("Hourly Rate?");
        string p2hr = Console.ReadLine();

        Console.WriteLine("Hours worked per week?");
        string p2hrswk = Console.ReadLine();

        //Casting string to int
        Console.WriteLine("Annual salary of Person 1:");
        int p1rate = Convert.ToInt32(p1hr);
        int p1worked = Convert.ToInt32(p1hrswk);
        int annualSalary1 = p1rate * p1worked * 52;
        Console.WriteLine(annualSalary1);
        Console.ReadLine();

        //Casting string to int
        Console.WriteLine("Annual salary of Person 2:");
        int p2rate = Convert.ToInt32(p2hr);
        int p2worked = Convert.ToInt32(p2hrswk);
        int annualSalary2 = p2rate * p2worked * 52;
        Console.WriteLine(annualSalary2);
        Console.ReadLine();

        //Using boolean logic
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.ReadLine();
        bool greaterthan = annualSalary1 > annualSalary2;
        Console.WriteLine(greaterthan);
        Console.ReadLine();

    }
}

