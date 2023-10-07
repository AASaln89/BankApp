using BankApp.Entities;
using BankApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.PostgreSQL
{
    public class LoanRepository : ILoanRepository
    {
        private readonly BankAppContext _context;

        public LoanRepository(BankAppContext context)
        {
            _context = context;
        }

        public Loan Add(Loan entity)
        {
            Loan bank = _context.Loans.Add(entity).Entity;
            _context.SaveChanges();

            return bank;
        }

        public void Delete(Guid uuid)
        {
            _context.Loans.Remove(new Loan() { UUID = uuid });
        }

        public IEnumerable<Loan> GetAll()
        {
            return _context.Loans.ToList();
        }

        public Loan Update(Loan entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
