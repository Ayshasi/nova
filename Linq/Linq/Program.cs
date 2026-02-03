using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list of numbers
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ Method Syntax → filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
0l̥