namespace BankApp.Entities
{
    /// <summary>
    /// Loan
    /// </summary>
    public class Loan : IEntityWithUUID
    {
        public Guid UUID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Client Client { get; set; }

        public string Number { get; set; }

        public decimal Ammount { get; set; }

        public decimal Percent { get; set; }

        public decimal Paid { get; set; }
    }
}
