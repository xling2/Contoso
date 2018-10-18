using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService()
        {
            _enrollmentRepository = new EnrollmentRepository(new ContosoDbContext());
        }
    }

    public interface IEnrollmentService
    {
    }
}
