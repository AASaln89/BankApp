using BankApp.Entities;
using BankApp.Repository.Interfaces;

namespace BankApp.Repository.FileImplementation
{
    public class LoanRepository : FileRepositoryBase<Loan>, ILoanRepository
    {
    }
}
