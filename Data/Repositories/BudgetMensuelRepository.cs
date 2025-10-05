using Budget.Data.Budget.Data;
using Budget.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data.Repositories
{
    public class BudgetMensuelRepository: IBudgetMensuelRepository
    {

        private BudgetDBContext _context;

        public BudgetMensuelRepository (BudgetDBContext context) {
            _context = context;
        }

        public decimal GetTotalRevenuByMonthAndByYear(int mois, int annee)
        {
            Console.WriteLine($"Recherche BudgetMensuel: Mois={mois}, Annee={annee}");
            var revenuByMonth = _context.BudgetsMensuels.Include(t => t.Transactions).FirstOrDefault(b => b.Mois == mois && b.Annee == annee);
            return revenuByMonth?.TotalRevenus ?? 0m;
        }
    }
}
