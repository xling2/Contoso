using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorService()
        {
            _instructorRepository = new InstructorRepository(new ContosoDbContext());
        }
    }

    public interface IInstructorService
    {
    }
}
