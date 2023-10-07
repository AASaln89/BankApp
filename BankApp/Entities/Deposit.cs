using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Entities
{
    /// <summary>
    /// Deposit
    /// </summary>

    public class Deposit : IEntityWithUUID
    {
        public Guid UUID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Client Client { get; set; }

        public string Number { get; set; }

        public decimal Ammount { get; set; }

        public decimal Percent { get; set; }
    }
}
