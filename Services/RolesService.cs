using QuizWebAssembly.Models.Roles;
using QuizWebAssembly.Models.Users;
using QuizWebAssembly.Pages.Admin;

namespace QuizWebAssembly.Services
{
    public class RolesService : CrudService<Role>
    {
        public RolesService()
        {
            var Role1 = new Role
            {
                Id = 1,
                Title = "test1"
            }; 
            var Role2 = new Role
            {
                Id = 2,
                Title = "test2"
            };
            _entityCache.Add(Role1.Id,Role1);
            _entityCache.Add(Role2.Id,Role2);
        }
    }
}
