class Program
{
    static void Main()
    {
        // Sample data from the assignment
        List<Timecard_Record> timecards = new List<Timecard_Record>
        {
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 1), "Regular", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 2), "Regular", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 3), "Regular", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 4), "Regular", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 5), "Regular", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Kyle James", "110011", new DateTime(2023, 1, 6), "Overtime", "Laborer", "001", 8, 15.5m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 1), "Regular", "Scrapper", "002", 10, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 2), "Regular", "Scrapper", "002", 10, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 3), "Regular", "Scrapper", "002", 10, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 4), "Regular", "Scrapper", "004", 10, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 5), "Overtime", "Scrapper", "004", 6, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 6), "Overtime", "Scrapper", "004", 6, 17.65m, 0),
            new Timecard_Record("Jane Smith", "120987", new DateTime(2023, 1, 7), "Double time", "Scrapper", "004", 5, 17.65m, 0),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 1), "Regular", "Foreman", "003", 8, 17.75m, 0),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 2), "Regular", "Foreman", "003", 12, 17.75m, 0),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 3), "Regular", "Foreman", "003", 10, 17.75m, 0),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 4), "Regular", "Foreman", "003", 10, 17.75m, 0),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 5), "Overtime", "Foreman", "003", 5, 17.75m, 125),
            new Timecard_Record("Amy Penn", "100002", new DateTime(2023, 1, 6), "Overtime", "Foreman", "003", 5, 17.75m, 175)
        };

        List<Rate_Table_Row> rateTable = new List<Rate_Table_Row>
        {
            new Rate_Table_Row("Laborer", "001", new DateTime(2023, 1, 1), new DateTime(2024, 1, 1), 18.75m),
            new Rate_Table_Row("Laborer", "002", new DateTime(2023, 1, 1), new DateTime(2024, 1, 1), 17.85m),
            new Rate_Table_Row("Scrapper", "002", new DateTime(2023, 1, 4), new DateTime(2024, 1, 1), 21.60m),
            new Rate_Table_Row("Foreman", "003", new DateTime(2023, 1, 1), new DateTime(2024, 1, 1), 15.60m)
        };

        PayrollProcessor processor = new PayrollProcessor();
        var summary = processor.Summarize_Pay_Info(timecards, rateTable);

        foreach (var record in summary)
        {
            Console.WriteLine($"{record.Employee_Name} | {record.Employee_Number} | {record.Earnings_Code} | Hours: {record.Total_Hours} | Pay: {record.Total_Pay_Amount:C} | Rate: {record.Rate_of_Pay:C}");
        }
    }
}