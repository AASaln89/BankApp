using BankApp.Entities;

namespace BankApp
{
    /// <summary>
    /// Cleint
    /// </summary>
    public class Client : IEntityWithUUID
    {
        public Guid UUID { get; set; }

        public Bank Bank { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Deposit> Deposits { get; set; }

        public List<Loan> Loans { get; set; }

        public string Number { get; set; }

        public decimal Ammount { get; set; }

        public ClientType Type { get; set; }

    }
}
