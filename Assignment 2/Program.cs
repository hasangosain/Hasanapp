using System;
class Program
{
    static void Main()
    {
        // Example age
        int age = 25;

        // Example height in feet
        float height = 5.9f;

        // Example weight in kg
        double weight = 70.5;

        // Example grade   
        char grade = 'A';

        // Example boolean
        bool isStudent = true;

        // Example name
        string name = "Hasan Gosain";

        // Example salary
        decimal salary = 50000.75m;

        // Example level
        byte level = 1;
        

        //display the variables
        Console.WriteLine($"Name: {name}");// Using string interpolation
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Is Student: " + isStudent);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Level: " + level);
        
    }
}