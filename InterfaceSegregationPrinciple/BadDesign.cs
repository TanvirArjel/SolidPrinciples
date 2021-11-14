namespace InterfaceSegregationPrinciple.BadDesign;

// Definition : Not client should be forced to implenmented an method that it does not use.

//Bad design example.
internal interface IEmployeeTasks
{
    void CreateSubTask();
    void AssginTask();
    void WorkOnTask();
}

internal class TeamLead : IEmployeeTasks
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

internal class Manager : IEmployeeTasks
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssginTask()
    {
        Console.WriteLine("Task assigned.");
    }

    // Does not work on task.
    public void WorkOnTask()
    {
        throw new NotImplementedException();
    }
}

internal class Programmer : IEmployeeTasks
{
    // Cannot create task.
    public void CreateSubTask()
    {
        throw new NotImplementedException();
    }

    // Cannot assing task.
    public void AssginTask()
    {
        throw new NotImplementedException();
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}
