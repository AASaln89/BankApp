using BankApp.Entities;
using BankApp.Repository.Interfaces;
using BankApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Services.ServiceImplementation
{
    public class ClientServices : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client entity)
        {
            return _clientRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _clientRepository.Delete(uuid);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client Update(Client entity)
        {
            return _clientRepository.Update(entity);
        }
    }
}
