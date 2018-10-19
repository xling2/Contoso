using Contoso.Model.Models;
using System.Collections.Generic;
using Contoso.Data.Repositories;
using Contoso.Data;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService()
        {
            //TODO use dependency injection, remove the creation of instances.
            _departmentRepository = new DepartmentRepository(new ContosoDbContext());
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return _departmentRepository.GetById(Id);
        }
        public void AddDepartment(Department department, List<string> role)
        {
            _departmentRepository.Add(department);
        }
        public void UpdateDepartment(Department department, List<string> role)
        {
            _departmentRepository.Update(department);
        }

        public void DeleteDepartment(Department department, List<string> role)
        {
            _departmentRepository.Delete(department);
        }
    }

    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();

        Department GetDepartmentById(int Id);

        void AddDepartment(Department department, List<string> roles);

        void UpdateDepartment(Department department, List<string> roles);

        void DeleteDepartment(Department department, List<string> roles);
    }
}
