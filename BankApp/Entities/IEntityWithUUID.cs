using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Entities
{
    public interface IEntityWithUUID
    {
        public Guid UUID { get; set; }
    }
}
