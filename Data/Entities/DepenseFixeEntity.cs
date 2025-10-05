namespace Budget.Data.Entities
{
    public class DepenseFixeEntity
    {
        public int Id { get; set; }
        public required string Libelle { get; set; }
        public required decimal Montant { get; set; }
        public string? Description { get; set; }
        public DateTime? DatePrelevement { get; set; }
        public required bool Actif { get; set; }
    }
}
