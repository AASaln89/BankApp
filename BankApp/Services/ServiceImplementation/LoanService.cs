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
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;

        public LoanService(ILoanRepository clientRepository)
        {
            _loanRepository = clientRepository;
        }

        public Loan Add(Loan entity)
        {
            return _loanRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _loanRepository.Delete(uuid);
        }

        public IEnumerable<Loan> GetAll()
        {
            return _loanRepository.GetAll();
        }

        public Loan Update(Loan entity)
        {
            return _loanRepository.Update(entity);
        }
    }
}
