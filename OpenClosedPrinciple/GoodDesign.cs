namespace OpenClosedPrinciple;

// Defintion : A software module or class should be designed in such way that it is open for extension and closed modification.

// This is good design example.

// Interface
internal interface IReportGeneration
{
    void GenerateReport();
}

// Clients
internal class PdfReportGeneration : IReportGeneration
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating pdf report.");
    }
}

internal class CsvReportGeneration : IReportGeneration
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating csv report.");
    }
}