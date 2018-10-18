using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService()
        {
            _roleRepository = new RoleRepository(new ContosoDbContext());
        }
    }

    public interface IRoleService
    {
    }
}
