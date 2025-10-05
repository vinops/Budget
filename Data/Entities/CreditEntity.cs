namespace Budget.Data.Entities
{
    public class CreditEntity
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public required decimal MontantTotal { get; set; }
        public decimal MontantRestant => MontantTotal - Transactions
            ?.Where(t => t.Type == TransactionType.RemboursementCredit)
            .Sum(t => t.Montant) ?? 0;
        public DateTime Echeance { get; set; }
        public ICollection<TransactionEntity>? Transactions { get; set; }
    }
}
