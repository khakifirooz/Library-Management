using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.User;

namespace ClassLibraryInfrastructure.Repositories
{
    public interface IUserRepository : IGenericRepository<int,User>
    {
        Task<User?> GetByUsernameAsync(string username);

        Task<User?> GetByCredentialsAsync(string username, string password);

        Task<bool> UsernameExistsAsync(string username);

        Task<User?> GetByEmailAsync(string email);

        Task<List<User>> SearchAsync(string? username, string? role, bool? isActive);

        Task UpdateLastLoginAsync(int userId);
    }
}
