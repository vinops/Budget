namespace Budget.Services
{
    public class MonthModel
    {
        public int Value { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class BudgetMensuelService
    {

        public List<MonthModel> MonthList = Enumerable.Range(1, 12)
            .Select(m => new MonthModel
            {
                Value = m,
                Name = new DateTime(1, m, 1).ToString("MMMM")
            })
            .ToList();
        
        public List<int> YearList = Enumerable.Range(DateTime.Now.Year - 5, 11).ToList();
    }
}
