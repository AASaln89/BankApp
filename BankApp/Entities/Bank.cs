namespace BankApp.Entities
{
    /// <summary>
    /// Bank
    /// </summary>
    public class Bank : IEntityWithUUID
    {
        public Guid UUID { get; set; }

        public string Name { get; set; }

        public List<Client> Clients { get; set; }
    }
}
