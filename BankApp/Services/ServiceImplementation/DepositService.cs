using BankApp.Entities;
using BankApp.Repository.Interfaces;
using BankApp.Services.Interfaces;

namespace BankApp.Services.ServiceImplementation
{
    public class DepositService : IDepositService
    {
        private readonly IDepositRepository _depositRepository;

        public DepositService(IDepositRepository clientRepository)
        {
            _depositRepository = clientRepository;
        }

        public Deposit Add(Deposit entity)
        {
            return _depositRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _depositRepository.Delete(uuid);
        }

        public IEnumerable<Deposit> GetAll()
        {
            return _depositRepository.GetAll();
        }

        public Deposit Update(Deposit entity)
        {
            return _depositRepository.Update(entity);
        }
    }
}
