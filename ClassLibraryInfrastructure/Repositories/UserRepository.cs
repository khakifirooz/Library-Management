//using Library_Manegment_Domain.User;

//namespace ClassLibraryInfrastructure.Repositories
//{
//    public class UserRepository : GenericRepository<int, User>, IUserRepository
//    {
//        private readonly LibraryMangementDbContext _context;

//        public UserRepository(LibraryMangementDbContext context) : base(context)
//        {
//            _context = context;
//        } 

//        public async Task<User?> GetByUsernameAsync(string username)
//        {
//            return await _context.Users
//                .FirstOrDefaultAsync(u => u.Username == username);
//        }

//        public async Task<User?> GetByCredentialsAsync(string username, string password)
//        {
//            var user = await GetByUsernameAsync(username);

//            if (user != null && BCrypt.Verify(password, user.PasswordHash))
//                return user;

//            return null;
//        }

//        public async Task<bool> UsernameExistsAsync(string username)
//        {
//            return await _context.Users.AnyAsync(u => u.Username == username);
//        }

//        public async Task<User?> GetByEmailAsync(string email)
//        {
//            if (string.IsNullOrWhiteSpace(email))
//                return null;

//            return await _context.Users
//                .FirstOrDefaultAsync(u => u.Email == email);
//        }

//        public async Task<List<User>> SearchAsync(string? username, string? role, bool? isActive)
//        {
//            var query = _context.Users.AsQueryable();

//            if (!string.IsNullOrWhiteSpace(username))
//                query = query.Where(u => u.Username.Contains(username));

//            if (!string.IsNullOrWhiteSpace(role))
//                query = query.Where(u => u.Role == role);

//            if (isActive.HasValue)
//                query = query.Where(u => u.IsActive == isActive.Value);

//            return await query.ToListAsync();
//        }

//        public async Task UpdateLastLoginAsync(int userId)
//        {
//            var user = await GetByIdAsync(userId);
//            if (user != null)
//            {
//                user.LastLoginDate = DateTime.Now;
//                await UpdateAsync(user);
//            }
//        }
//    }
//}
