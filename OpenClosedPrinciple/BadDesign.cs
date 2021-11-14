// Defintion : A software module or class should be designed in such way that it is open for extension and closed modification.

namespace OpenClosedPrinciple;

// Bad Design Example:
public class ReportGeneration
{
    /// <summary>
    /// Report type
    /// </summary>
    public string ReportType { get; set; }

    /// <summary>
    /// Method to generate report
    /// </summary>
    /// <param name="employee"></param>
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