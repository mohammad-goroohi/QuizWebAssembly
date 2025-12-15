
using QuizWebAssembly.Models.Users;

namespace QuizWebAssembly.Services
{
    public class UsersService
    {
        private Dictionary<int, User> _users = new Dictionary<int, User>();
        public async Task<List<UserViewModel>> GetUsersAsync()
        {
            return await Task.FromResult(_users.Select(u => new UserViewModel
            {
                Id = u.Value.Id,
                FirstName = u.Value.FirstName,
                LastName = u.Value.LastName,
                UserName = u.Value.UserName,
            }).ToList());
        }
        public async Task<UserViewModel> GetUserByIdAsync(int Id)
        {

            var user = _users[Id];
            return await Task.FromResult(new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
            });
        }
        public async Task CreateUserAsync(User user)
        {
            user.Id = new Random().Next();
            _users.Add(user.Id, user);
            await Task.CompletedTask;
        }
        public async Task DeleteUserAsync(int UserId)
        {
            _users.Remove(UserId);
            await Task.CompletedTask;
        }
    }
}
