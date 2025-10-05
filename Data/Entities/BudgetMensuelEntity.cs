namespace Budget.Data.Entities
{
    public class BudgetMensuelEntity
    {
        public int Id { get; set; }
        public required int Annee { get; set; }
        public required int Mois { get; set; }
        public decimal TotalRevenus => Transactions.Where(t => t.Type == TransactionType.Revenu)
            .Sum(t => t.Montant);
        public decimal TotalDepenses => Transactions.Where(t => t.Type == TransactionType.Depense)
            .Sum(t => t.Montant);
        public decimal SoldeRestant => TotalRevenus - TotalDepenses;
        public required ICollection<TransactionEntity> Transactions { get; set; }
    }
}
