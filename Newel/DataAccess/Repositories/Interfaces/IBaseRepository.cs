using DataAccess.Model;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        ValueTask<T> GetByIdAsync(Guid id);
    }
}
