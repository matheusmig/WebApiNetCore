using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBaseRepository<T> where T : IEntity
    {
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> FindAllAsync(ISearchFilter filters);
        Task<int> FindAllCountAsync(ISearchFilter filters);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
