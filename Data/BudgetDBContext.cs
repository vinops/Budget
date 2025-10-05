namespace Budget.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;


    namespace Budget.Data
    {
        public class BudgetDBContext : DbContext
        {
            public BudgetDBContext(DbContextOptions<BudgetDBContext> options)
                : base(options){
            }

            public DbSet<BudgetMensuelEntity> BudgetsMensuels { get; set; }
            public DbSet<TransactionEntity> Transactions { get; set; }
            public DbSet<CreditEntity> Credits { get; set; }
            public DbSet<DepenseFixeEntity> DepensesFixes { get; set; }

            }
    }
}
