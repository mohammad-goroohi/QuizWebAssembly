using QuizWebAssembly.Models.Shared;
using QuizWebAssembly.Models.Users;
namespace QuizWebAssembly.Models.Roles
{
    public class Role :  BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public List<User> Users { get; set; } = new List<User>();
    }
}
