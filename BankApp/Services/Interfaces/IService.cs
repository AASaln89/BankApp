using BankApp.Entities;

namespace BankApp.Services.Interfaces
{
    public interface IService <T> where T : IEntityWithUUID 
    {
        IEnumerable<T> GetAll();

        T Add(T entity);

        T Update(T entity);

        void Delete(Guid uuid);
    }
}
