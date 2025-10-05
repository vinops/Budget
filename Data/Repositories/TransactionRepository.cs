using Budget.Data.Budget.Data;
using Budget.Data.Entities;

namespace Budget.Data.Repositories
{
    public class TransactionRepository
    {

        private BudgetDBContext _context;

        public TransactionRepository(BudgetDBContext context)
        {
            _context = context;
        }

        public TransactionEntity? GetTransaction(int id)
        {
            var transaction = _context.Transactions.Where(d => d.Id == id).FirstOrDefault();
            return transaction;
        }

        public void AddTransaction(TransactionEntity transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void DeleteTransaction(TransactionEntity transaction)
        {
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }

        public IEnumerable<TransactionEntity> GetAllTransactionByMonth(DateTime month)
        {
            IEnumerable<TransactionEntity> monthTransaction = _context.Transactions.Where(m => m.Date == month).ToList();
            return monthTransaction;
        }

    }
}
