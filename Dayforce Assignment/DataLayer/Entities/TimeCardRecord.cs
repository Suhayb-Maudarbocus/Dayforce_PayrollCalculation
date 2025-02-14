public record Timecard_Record
{
    public string Employee_Name { get; set; }
    public string Employee_Number { get; set; }
    public DateTime Date_Worked { get; set; }
    public string Earnings_Code { get; set; }
    public string Job_Worked { get; set; }
    public string Dept_Worked { get; set; }
    public decimal Hours { get; set; }
    public decimal Rate { get; set; }
    public decimal Bonus { get; set; }

    public Timecard_Record(string employeeName, string employeeNumber, DateTime dateWorked, string earningsCode,
                           string jobWorked, string deptWorked, decimal hours, decimal rate, decimal bonus)
    {
        Employee_Name = employeeName;
        Employee_Number = employeeNumber;
        Date_Worked = dateWorked;
        Earnings_Code = earningsCode;
        Job_Worked = jobWorked;
        Dept_Worked = deptWorked;
        Hours = hours;
        Rate = rate;
        Bonus = bonus;
    }
}