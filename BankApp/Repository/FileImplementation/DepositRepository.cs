using BankApp.Entities;
using BankApp.Repository.Interfaces;

namespace BankApp.Repository.FileImplementation
{
    public class DepositRepository : FileRepositoryBase<Deposit>, IDepositRepository
    {
    }
}
