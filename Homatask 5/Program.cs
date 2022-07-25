using System;

public class App
{
    public static void Main(string[] args)
    {
        Animal dog = new Bulldog();
        dog.FoodIntake = 5;
        dog.MakeSound();


        Calculator.Sum(4, 5);
        Calculator.Sum(3, 4.2);
        Calculator.Sum(0.4, 1.2);
        Calculator.Sum(4, 5, 5);

    }
}

abstract class Animal
{
    // Classic property (with backing field)
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Auto-implemented property
    public int FoodIntake { get; set; }

    // Read-only property
    public int BirthYear { get; }

    // Set-only property
    private string _cagepassword;
    public string CagePassword { set { _cagepassword = value; } }

    // Calculated property
    public int Age
    {
        get { return new Random().Next(1, 7); }
    }

    abstract public void MakeSound();


}

// Creating a hierarchy
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}

// Creating a hierarchy
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Bulldog : Dog
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Calculator
{
    static public void Sum (int i, int j)
    {
        Console.WriteLine("Sum is " + (i + j));
    }
    static public void Sum(int i, int j, int q)
    {
        Console.WriteLine("Sum is " + (i + j + q));
    }
    static public void Sum(int i, double j)
    {
        Console.WriteLine("Sum is " + (i + j));
    }
    static public void Sum(double i, double j)
    {
        Console.WriteLine("Sum is " + (i + j));
    }
}