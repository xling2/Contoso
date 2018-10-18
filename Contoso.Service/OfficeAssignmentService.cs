using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class OfficeAssignmentService : IOfficeAssignmentService
    {
        private readonly IOfficeAssignmentRepository _officeAssignmentRepository;

        public OfficeAssignmentService()
        {
            _officeAssignmentRepository = new OfficeAssignmentRepository(new ContosoDbContext());
        }
    }

    public interface IOfficeAssignmentService
    {
    }
}
