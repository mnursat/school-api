using School.API.Models;

namespace School.API.Persistence;

public interface IEmployeeRepository
{
    public IEnumerable<Employee> GetEmployees();
    public Employee GetEmployee(int id);
    public IEnumerable<Employee> GetEmployeesByJobTitle(string jobTitle);
    public void CreateEmployee(Employee employee);
    public void UpdateEmployee(int id, Employee employee);
    public void DeleteEmployee(int id);
}