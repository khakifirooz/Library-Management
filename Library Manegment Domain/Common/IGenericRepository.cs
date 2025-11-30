using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Library_Manegment_Domain.Common
{
    public interface IGenericRepository<TKey,T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(TKey id);
        Task<List<T>> GetAllAsync();
        Task<bool> ExistAsync(Expression<Func<T, bool>> predicate);
        Task SavaChangesAsync();
    }
}
