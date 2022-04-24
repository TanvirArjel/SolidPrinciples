# Liskov Substitution Principle
This principle states that:

 >***A child/sub/derived class should be completely substitutable to its base or parent class.***

 This principle is very similar to the **Interface Segregation Principle**. This principal is also related to the `Polymorphism` which is one of the four pillars of OOP.
 
 ## Bad Design
 According to the **Liskov Substitution Principle**, the following code is a bad design.
 
 ```C#
 // Interface
internal interface IBird
{
    void MakeSound();

    void Fly();

    void Run();
}

// Implementations
public class Duck : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

// This breaks the Liskov substituion principle because if we follow polymorphism and call the Fly() method from IBird reference variable
// then it will throw NotImplementedException.
public class Ostrich : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    // Ostrich cannot fly.
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}
 ```
 The Problem is:
 
 If we follow **Polymorphism** and call the `Fly()` method from `IBird` reference variable with `Ostrich` object then it will throw `NotImplementedException` as follows:
  
```C#
IBird bird = new Ostrich();
bird.Fly(); // Will throw NotImplementedException
```
## Good Design
If we redesign the above code as follows, it will solve the above issue.
```C#
// Interfaces
internal interface IBird
{
    void MakeSound();

    void Run();
}

internal interface IFlyingBird : IBird
{
    void Fly();
}

public class Duck : IFlyingBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

public class Ostrich : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}
```
**Now it looks fine, isn't it?**
