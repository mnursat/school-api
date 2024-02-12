using Microsoft.AspNetCore.Mvc;
using School.API.Models;
using School.API.Persistence;

namespace School.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    /// <summary>
    /// Getting a list of all employees as JSON
    /// </summary>
    /// <returns>A list of all employees</returns>
    /// <response code="200">Returns employees</response>
    /// <response code="404">If employees not found</response>
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = _employeeRepository.GetEmployees();

        if (!employees.Any())
        {
            return NotFound("Employees not found");
        }

        return Ok(employees);
    }

    /// <summary>
    /// Getting a list of employees by job title as JSON
    /// </summary>
    /// <param name="jobTitle">The job title to search for</param>
    /// <remarks>Start with capital letter</remarks>
    /// <returns>A list of students</returns>
    /// <response code="200">Returns employees filtered by job title</response>
    /// <response code="404">If employees by job title not found</response>
    [HttpGet("{jobTitle}")]
    public IActionResult GetEmployeesByJobTitle(string jobTitle)
    {
        var employees = _employeeRepository.GetEmployeesByJobTitle(jobTitle);

        if (!employees.Any())
        {
            return NotFound("Employees not found");
        }

        return Ok(employees);
    }

    /// <summary>
    /// Create a employee as JSON
    /// </summary>
    /// <param name="employee">The employee object to create for</param>
    /// <remarks>The API return bad request if id less or equal to 0</remarks>
    /// <returns>No content method</returns>
    /// <response code="204">Returns no content that means successfully created employee</response>
    /// <response code="400">If id less or equal to zero</response>
    [HttpPost]
    public IActionResult CreateEmpoloyee(Employee employee)
    {
        if (employee.Id <= 0)
        {
            return BadRequest("Id must be positive");
        }

        _employeeRepository.CreateEmployee(employee);
        return NoContent();
    }

    /// <summary>
    /// Update a employee by id
    /// </summary>
    /// <param name="id">The id to search for</param>
    /// <param name="employee">The new employee object to update for exist student</param>
    /// <remarks>The API return not found if that id does not exist</remarks>
    /// <returns>No content method</returns>
    /// <response code="204">Returns no content</response>
    /// <response code="404">If employee not found</response>
    [HttpPut]
    public IActionResult UpdateEmpoEmployee(int id, Employee employee)
    {
        var existEmployee = _employeeRepository.GetEmployee(id);

        if (existEmployee is null)
        {
            return NotFound();
        }

        _employeeRepository.UpdateEmployee(id, employee);
        return NoContent();
    }

    /// <summary>
    /// Delete a employee by id
    /// </summary>
    /// <param name="id">The id to search for</param>
    /// <remarks>The API return not found if that id does not exist</remarks>
    /// <response code="204">Returns no content</response>
    /// <response code="404">If employee not found</response>
    [HttpDelete]
    [HttpDelete]
    public IActionResult DeleteEmployee(int id)
    {
        var existEmployee = _employeeRepository.GetEmployee(id);

        if (existEmployee is null)
        {
            return NotFound();
        }

        _employeeRepository.DeleteEmployee(id);
        return NoContent();
    }
}
