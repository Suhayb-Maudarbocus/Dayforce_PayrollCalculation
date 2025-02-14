public record Rate_Table_Row
{
    public string Job { get; set; }
    public string Dept { get; set; }
    public DateTime Effective_Start { get; set; }
    public DateTime Effective_End { get; set; }
    public decimal Hourly_Rate { get; set; }

    public Rate_Table_Row(string job, string dept, DateTime effectiveStart, DateTime effectiveEnd, decimal hourlyRate)
    {
        Job = job;
        Dept = dept;
        Effective_Start = effectiveStart;
        Effective_End = effectiveEnd;
        Hourly_Rate = hourlyRate;
    }
}