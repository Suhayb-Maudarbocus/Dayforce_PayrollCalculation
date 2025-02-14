public class PayrollProcessor
{

    public List<Pay_Summary_Record> Summarize_Pay_Info(List<Timecard_Record> timecards, List<Rate_Table_Row> rateTable)
    {
        List<Pay_Summary_Record> summary = new List<Pay_Summary_Record>();

        var groupedRecords = timecards.GroupBy(tc => new { tc.Employee_Name, tc.Employee_Number, tc.Earnings_Code, tc.Job_Worked, tc.Dept_Worked });

        foreach (var group in groupedRecords)
        {
            decimal totalHours = group.Sum(tc => tc.Hours);
            decimal highestRate = group.Max(tc =>
            {
                var applicableRate = rateTable.FirstOrDefault(r => r.Job == tc.Job_Worked && r.Dept == tc.Dept_Worked && r.Effective_Start <= tc.Date_Worked && r.Effective_End >= tc.Date_Worked);
                return applicableRate != null ? Math.Max(tc.Rate, applicableRate.Hourly_Rate) : tc.Rate;
            });

            decimal totalPay = group.Sum(tc =>
            {
                decimal appliedRate = highestRate;
                if (tc.Earnings_Code == "Overtime") appliedRate *= 1.5m;
                else if (tc.Earnings_Code == "Double time") appliedRate *= 2;

                return appliedRate * tc.Hours + tc.Bonus;
            });

            summary.Add(new Pay_Summary_Record(
                            group.Key.Employee_Name,
                            group.Key.Employee_Number,
                            group.Key.Earnings_Code,
                            totalHours,
                            totalPay,
                            highestRate,
                            group.Key.Job_Worked,
                            group.Key.Dept_Worked
                        ));
        }

        return summary;
    }
}