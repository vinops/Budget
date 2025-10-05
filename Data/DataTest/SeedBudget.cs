using Budget.Data.Budget.Data;
using Budget.Data.Entities;
using System.Reflection.Metadata;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Budget.Data.DataTest
{
    public static class SeedBudget
    {
        public static void Seed(BudgetDBContext context)
        {
            if (!context.BudgetsMensuels.Any())
            {
                var janvier = new BudgetMensuelEntity
                {
                    Mois = 1,
                    Annee = 2024,
                    Transactions = new List<TransactionEntity>
                    {
                        new TransactionEntity
                        {
                            Date = new DateTime(2024, 1, 5),
                            Montant = 1500m,
                            Type = TransactionType.Revenu,
                            Libelle = "Salaire",
                            BudgetMensuelId = 1,
                            Description = "Salaire mensuel"
                        },
                        new TransactionEntity
                        {
                            Date = new DateTime(2024, 1, 10),
                            Montant = 500m,
                            Type = TransactionType.Revenu,
                            Libelle = "Freelance",
                            BudgetMensuelId = 1,
                            Description = "Projet freelance"
                        },
                        new TransactionEntity
                        {
                            Date = new DateTime(2024, 1, 15),
                            Montant = 800m,
                            Type = TransactionType.Depense,
                            Libelle = "Loyer",
                            BudgetMensuelId = 1,    
                            Description = "Loyer mensuel"
                        },
                        new TransactionEntity
                        {
                            Date = new DateTime(2024, 1, 20),
                            Montant = 200m,
                            Type = TransactionType.Depense,
                            Libelle = "Courses",
                            BudgetMensuelId = 1,
                            Description = "Courses alimentaires"
                        },
                         new TransactionEntity{
                            Date = new DateTime(2024, 1, 20),
                            Montant = 200m,
                            Type = TransactionType.Depense,
                            Libelle = "Courses",
                            BudgetMensuelId = 1,
                            CreditId = 1,
                            Description = "Courses alimentaires"
                        }
                    }
                };
                var creditAuto = new CreditEntity
                {
                    Nom = "Crédit Auto",
                    MontantTotal = 10000m,
                    Echeance = new DateTime(2026, 12, 31)
                };
                var depenseFixeInternet = new DepenseFixeEntity
                {
                    Libelle = "Abonnement Internet",
                    Montant = 21.99m,
                    Description = "Bouygue Telecom",
                    Actif = true
                };

                context.Credits.Add(creditAuto);
                context.DepensesFixes.Add(depenseFixeInternet);
                context.BudgetsMensuels.Add(janvier);
                context.SaveChanges();

            }
        }
    }
}
