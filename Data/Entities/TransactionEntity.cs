namespace Budget.Data.Entities
{

    public enum TransactionType { 
        Revenu,
        Depense,
        RemboursementCredit
    }
    public class TransactionEntity
    {
        public int Id { get; set; }
        public required string Libelle { get; set; }
        public DateTime Date { get; set; }
        public required decimal Montant { get; set; }
        public required TransactionType Type { get; set; }
        public string? Description { get; set; }
        public required int BudgetMensuelId { get; set; }
        public BudgetMensuelEntity BudgetMensuel { get; set; } = null!;
        public int? CreditId { get; set; }
        public CreditEntity? Credit { get; set; }
    }
}
