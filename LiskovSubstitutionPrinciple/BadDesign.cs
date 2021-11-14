// Defition: A child/sub/derived class should be completely substitutable to it's base or parent class. This principle is very similar to the
// Interface Segration Principle.

namespace LiskovSubstitutionPrinciple.BadDesign;

// Interfaces
internal interface IBird
{
    void MakeSound();

    void Fly();

    void Run();
}

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

// This breaks the Liskov substituion principle because if we follow polymorphism and call the Run() method from IBird reference variable
// then it will throw NotImplementedException.
public class Ostrich : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    // Cannot fly.
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}