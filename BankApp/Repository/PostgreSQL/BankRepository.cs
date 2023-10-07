using BankApp.Entities;
using BankApp.Repository.Interfaces;

namespace BankApp.Repository.PostgreSQL
{
    public class BankRepository : IBankRepository
    {
        private readonly BankAppContext _context;

        public BankRepository(BankAppContext context) 
        {  
            _context = context;
        }

        public Bank Add(Bank entity)
        {
            Bank bank = _context.Banks.Add(entity).Entity;
            _context.SaveChanges();

            return bank;
        }

        public void Delete(Guid uuid)
        {
            _context.Banks.Remove(new Bank() { UUID = uuid });
        }

        public IEnumerable<Bank> GetAll()
        {
            return _context.Banks.ToList();
        }

        public Bank Update(Bank entity)
        {
            
            return _context.Update(entity).Entity;
        }
    }
}
