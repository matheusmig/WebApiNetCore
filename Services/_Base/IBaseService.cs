using Models;
using Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IBaseService<T> where T : IEntity
    {
        ServiceResponse<T> FindById(int id);
        ServiceResponse<IEnumerable<T>> FindAll(ISearchFilter filters);
        ServiceResponse<int> FindAllCount(ISearchFilter filters);
        Task<ServiceResponse<T>> InsertAsync(T entity);
        ServiceResponse<T> Update(T entity);
        ServiceResponse<T> Delete(int id);
    }
}
