using System;



class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name} eats food.");

    }
    public void sleep()
    {
        Console.WriteLine($"{Name} sleeps.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Name = "Kutta";
        d.Eat();   // Inherited method
        d.Bark();  // Derived class method

        Cat c = new Cat();
        c.Name = "Bilai";
        c.Meow();
        c.sleep();

    }
}



