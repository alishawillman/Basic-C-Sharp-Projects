using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //Array of strings
        string[] stringArray = { "Alisha", "Joey", "Luna", "Zeus", "Gus"};
        //Ask user to select index of stringArray
        Console.WriteLine("Select an index of the string array.");
        int index = int.Parse(Console.ReadLine());
        
        //Error messgae if index doesn't exist using if else statement
        if (index <= stringArray.Length)
        {
            Console.WriteLine(stringArray[index]);
        }
        else
        {
            Console.WriteLine("That index does not exist!");
        }

        //Array of integers
        int[] numArray = { 126, 32, 67, 89, 327 };
        //Ask the user to select an index of the Array
        Console.WriteLine("Select an index of the number array.");
        int index1 = int.Parse(Console.ReadLine());

        //Error message for index that doesn't exist using try catch 
        try
        {
            Console.WriteLine(numArray[index1]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



        //List of strings
        List<string> stringList = new List<string>();
        stringList.Add("Hello,");
        stringList.Add("World!");
        stringList.Add("Have");
        stringList.Add("a");
        stringList.Add("great");
        stringList.Add("day!");

        //Ask the user to select an index of the list
        Console.WriteLine("Select an index of the list.");
        int index2 = int.Parse(Console.ReadLine());

        //Error message using try catch again
        try
        {
            Console.WriteLine(stringList[index2]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Read();
    }
}

