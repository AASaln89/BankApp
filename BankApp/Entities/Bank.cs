using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
