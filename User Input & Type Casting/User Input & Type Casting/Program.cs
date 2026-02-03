using System;

class Program
{
    static void Main()
    {
        // Task 1: Ask for name & age → print greeting
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hello {name}, you are {age} years old!");

        Console.WriteLine("\n--- Task 2: Sum of two numbers ---");

        // Task 2: Take 2 numbers from user → print sum
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

        Console.WriteLine("\n--- Task 3: Convert double to int ---");

        // Task 3: Convert double to int and show result
        Console.Write("Enter a decimal (double) number: ");
        double d = Convert.ToDouble(Console.ReadLine());

        int converted = (int)d;  // explicit conversion
        Console.WriteLine($"The double {d} converted to int is {converted}");

        // Extra: GCD and Prime check
        Console.WriteLine("\n--- GCD and Prime Check ---");
        Console.Write("Enter first number for GCD: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number for GCD: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"GCD of {a} and {b} = {GCD(a, b)}");

        Console.Write("Enter a number to check if prime: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? $"{n} is Prime" : $"{n} is NOT Prime");

        // Extra: Student Example
        Student student1 = new Student { Name = "Aysha", Age = 21, Grade = "A" };
        student1.DisplayDetails();

    }

    // Method for GCD
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Method for Prime check
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }


    // Student class
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
