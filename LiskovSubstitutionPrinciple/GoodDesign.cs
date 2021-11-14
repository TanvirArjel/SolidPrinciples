// Defition: A child/sub/derived class should be completely substitutable to it's base or parent class. This principle is very similar to the
// Interface Segration Principle.

namespace LiskovSubstitutionPrinciple.GoodDesign;

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