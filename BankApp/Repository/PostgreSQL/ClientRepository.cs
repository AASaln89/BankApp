using BankApp.Entities;
using BankApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.PostgreSQL
{
    public class ClientRepository : IClientRepository
    {
        private readonly BankAppContext _context;

        public ClientRepository(BankAppContext context)
        {
            _context = context;
        }

        public Client Add(Client entity)
        {
            Client client = _context.Clients.Add(entity).Entity;
            _context.SaveChanges();

            return client;
        }

        public void Delete(Guid uuid)
        {
            _context.Clients.Remove(new Client() { UUID = uuid });
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients
                .Include(c => c.Deposits)
                .Include(c => c.Loans)
                .ToList();
        }

        public Client Update(Client entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
