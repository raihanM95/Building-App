using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id) => throw new NotImplementedException();
        Task<int> AddAsync(T entity) => throw new NotImplementedException();
        Task<int> UpdateAsync(T entity) => throw new NotImplementedException();
        Task<int> DeleteAsync(int id) => throw new NotImplementedException();
    }
}
