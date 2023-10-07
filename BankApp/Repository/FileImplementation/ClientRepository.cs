using BankApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.FileImplementation
{
    public class ClientRepository : FileRepositoryBase<Client>, IClientRepository
    {
    }
}
