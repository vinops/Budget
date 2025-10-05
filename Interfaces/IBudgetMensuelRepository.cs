namespace Budget.Interfaces
{
    public interface IBudgetMensuelRepository
    {
        decimal GetTotalRevenuByMonthAndByYear(int mois, int annee);
    }
}
