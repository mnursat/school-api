using School.API.Models;

namespace School.API.Persistence;

public class EmployeeRepository : IEmployeeRepository
{
    public void CreateEmployee(Employee employee)
    {
        Data.CreateEmployee(employee);
    }

    public void DeleteEmployee(int id)
    {
        Data.Employees.Remove(Data.Employees[id - 1]);
    }

    public Employee GetEmployee(int id)
    {
        return Data.Employees[id-1];
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return Data.Employees;
    }

    public IEnumerable<Employee> GetEmployeesByJobTitle(string jobTitle)
    {
        return Data.Employees.Where(e => e.JobTitle.Equals(jobTitle));
    }

    public void UpdateEmployee(int id, Employee employee)
    {
        Data.Employees[id - 1] = employee;
    }
}