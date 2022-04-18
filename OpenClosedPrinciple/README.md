# Open Closed Principle
This principle states that:

>***A software module or class should be designed in such way that it is open for extension and closed modification.***

## Bad Design
According to the **Open Closed Principle**, the following class design is a bad design.

```C#
public class ReportGeneration
{
    public ReportGeneration(string reportType) 
    {
       ReportType = reportType;
    }
    
    public string ReportType { get; }
    
    public void GenerateReport(Employee employee)
    {
        if (ReportType == "CRS")
        {
            // Report generation with employee data in Crystal Report.
        }
        if (ReportType == "PDF")
        {
            // Report generation with employee data in PDF.
        }
    }
}
```

The Problems are:
  1. If we would like to add **CSV Report Generation** then we have to modify the `ReportGeneration` class.
  2. We have to test all the functionalities of the `ReportGeneration` class again to make sure that with the latest modification no existing functionalities have been broken.

## Good Design
If we design the ReportGeneration as follows then we can add as many types of new ReportGenerations without altering the existing ReportGeneration classes.

```C#
// Interface
public interface IReportGeneration
{
    void GenerateReport(Employee employee);
}

// Clients
public class PdfReportGeneration : IReportGeneration
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine("Generating pdf report.");
    }
}

public class CRSReportGeneration : IReportGeneration
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine("Generating CRS report.");
    }
}

public class CsvReportGeneration : IReportGeneration
{
    public void GenerateReport(Employee employee)
    {
        Console.WriteLine("Generating csv report.");
    }
}
```
Now it looks fantastic, isn't it?
