public record Pay_Summary_Record
{
    public string Employee_Name { get; set; }
    public string Employee_Number { get; set; }
    public string Earnings_Code { get; set; }
    public decimal Total_Hours { get; set; }
    public decimal Total_Pay_Amount { get; set; }
    public decimal Rate_of_Pay { get; set; }
    public string Job { get; set; }
    public string Dept { get; set; }

    public Pay_Summary_Record(string employee_Name, string employee_Number, string earnings_Code, decimal totalHours, decimal totalPay, decimal highestRate, string job_Worked, string dept_Worked)
    {
        Employee_Name = employee_Name;
        Employee_Number = employee_Number;
        Earnings_Code = earnings_Code;
        Total_Hours = totalHours;
        Total_Pay_Amount = totalPay;
        Rate_of_Pay = highestRate;
        Job = job_Worked;
        Dept = dept_Worked;
    }
}