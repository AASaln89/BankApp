using BankApp.Entities;
using BankApp.Repository.Interfaces;
using BankApp.Services.Interfaces;

namespace BankApp.Services.ServiceImplementation
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository) 
        {
            _bankRepository = bankRepository;
        }

        public Bank Add(Bank entity)
        {
            return _bankRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _bankRepository.Delete(uuid);
        }

        public IEnumerable<Bank> GetAll()
        {
            return _bankRepository.GetAll();
        }

        public Bank Update(Bank entity)
        {
            return _bankRepository.Update(entity);
        }
    }
}
