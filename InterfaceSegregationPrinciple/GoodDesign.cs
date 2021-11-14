
// Definition : Not client should be forced to implenmented an method that it does not use.

// Procedure: One fat interface needs to be split to many smaller and relevant interfaces so that clients can know which
// interfaces it should implement.

//Good design example.

namespace InterfaceSegregationPrinciple.GoodDesign;


// Interfaces
internal interface ILead
{
    void CreateSubTask();
    void AssginTask();
}

internal interface IProgrammer
{
    void WorkOnTask();
}

// Clients
internal class Manager : ILead
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssginTask()
    {
        Console.WriteLine("Task assigned.");
    }
}

internal class TeamLead : ILead, IProgrammer
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssginTask()
    {
        Console.WriteLine("Task assigned.");
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

internal class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}