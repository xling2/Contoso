using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository(new ContosoDbContext());
        }
    }

    public interface IStudentService
    {
    }
}
