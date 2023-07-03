﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer value between 1 and 100:");
        int userInput;

        // Validate user input using try/catch block
        try
        {
            userInput = int.Parse(Console.ReadLine());

            if (userInput < 1 || userInput > 100)
            {
                Console.WriteLine("Invalid input. Please enter a value between 1 and 100.");
                return;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer value.");
            return;
        }

        Console.WriteLine("Please specify the series of numbers you want to display (even/odd):");
        string series = Console.ReadLine();

        Console.WriteLine($"You have selected the {series} series. The numbers between 0 and {userInput} are:");

        // Display the numbers in the series based on user input
        int i = 0;

        while (i <= userInput)
        {
            if (series == "even" && i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else if (series == "odd" && i % 2 != 0)
            {
                Console.WriteLine(i);
            }

            i++;
        }
    }
}
