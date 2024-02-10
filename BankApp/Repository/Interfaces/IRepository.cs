using BankApp.Entities;

namespace BankApp.Repository.Interfaces
{
    public interface IRepository<T> where T : IEntityWithUUID
    {
        IEnumerable<T> GetAll();

        T Add(T entity);

        T Update(T entity);

        void Delete(Guid uuid);
    }
}
