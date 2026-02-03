using System;

// interface 
public interface Student
{
    //abstract method
    void FavSub();
}

// Subclass for functionality
public class Abc : Student
{
    public void FavSub()
    {
        Console.WriteLine("Hello! How are you? ");
    }
}


public class Geeks
{
    public static void Main()
    {
        Student obj = new Abc();

        obj.FavSub();
    }
}