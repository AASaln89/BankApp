using BankApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
