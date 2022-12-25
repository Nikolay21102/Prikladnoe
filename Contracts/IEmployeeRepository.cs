using ShopApi.Entities.Models;

namespace ShopApi.Contracts;

public interface IEmployeeRepository : IRepositoryBase<Employee>
{
    IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
    Employee? GetEmployee(Guid companyId, Guid id, bool trackChanges);
    void CreateEmployeeForCompany(Guid companyId, Employee employee);
}