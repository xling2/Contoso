using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService()
        {
            _courseRepository = new CourseRepository(new ContosoDbContext());
        }
    }

    public interface ICourseService
    {
    }
}
