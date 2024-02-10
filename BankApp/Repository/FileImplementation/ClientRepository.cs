using BankApp.Repository.Interfaces;

namespace BankApp.Repository.FileImplementation
{
    public class ClientRepository : FileRepositoryBase<Client>, IClientRepository
    {
    }
}
