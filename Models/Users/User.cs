using QuizWebAssembly.Models.Shared;

namespace QuizWebAssembly.Models.Users
{
    public class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
