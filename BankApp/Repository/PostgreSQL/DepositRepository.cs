using BankApp.Entities;
using BankApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.PostgreSQL
{
    public class DepositRepository : IDepositRepository
    {
        private readonly BankAppContext _context;

        public DepositRepository(BankAppContext context)
        {
            _context = context;
        }

        public Deposit Add(Deposit entity)
        {
            Deposit bank = _context.Deposits.Add(entity).Entity;
            _context.SaveChanges();

            return bank;
        }

        public void Delete(Guid uuid)
        {
            _context.Deposits.Remove(new Deposit() { UUID = uuid });
        }

        public IEnumerable<Deposit> GetAll()
        {
            return _context.Deposits.ToList();
        }

        public Deposit Update(Deposit entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
