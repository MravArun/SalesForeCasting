using CLAP;

namespace SalesForeCasting;

public class SalesForeCastingCommands
{
    /// <summary>
    /// Upload the forecasting data
    /// </summary>
    /// <param name="filePath"></param>
    [Verb]
    public void UploadForeCastingData([Required] string filePath)
    {
        
    }

    /// <summary>
    /// Get forecasting data for the specified year
    /// </summary>
    /// <param name="year"></param>
    [Verb]
    public void GetForeCasting([Required] int year)
    {
        
    }

    /// <summary>
    /// Apply percentage and download the data.
    /// </summary>
    /// <param name="percentage"></param>
    /// <param name="download"></param>
    [Verb]
    public void ApplyPercentage([Required] decimal percentage, bool download)
    {
        
    }
}