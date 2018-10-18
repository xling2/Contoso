using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService()
        {
            _peopleRepository = new PeopleRepository(new ContosoDbContext());
        }
    }

    public interface IPeopleService
    {
    }
}
