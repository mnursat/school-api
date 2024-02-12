using Microsoft.AspNetCore.Mvc;
using School.API.Models;
using School.API.Persistence;

namespace School.API.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;

    public StudentsController(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    /// <summary>
    /// Getting a list of all students as JSON
    /// </summary>
    /// <returns>A list of all students</returns>
    /// <response code="200">Returns students</response>
    /// <response code="404">If students not found</response>
    [Produces("application/json")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetStudents()
    {
        var students = _studentRepository.GetStudents();

        if (students == null)
        {
            return NotFound();
        }

        return Ok(students);
    }

    /// <summary>
    /// Getting a list of students by class name as JSON
    /// </summary>
    /// <param name="className">The class name to search for</param>
    /// <returns>A list of students</returns>
    /// <response code="200">Returns students filtered by class</response>
    /// <response code="404">If students by class not found</response>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /Students/Teacher
    /// </remarks>
    [HttpGet("{className}")]
    public IActionResult GetStudentsByClass(string className)
    {
        var students = _studentRepository.GetStudentsByClass(className.ToUpper());

        if (students == null)
        {
            return NotFound();
        }

        return Ok(students);
    }

    /// <summary>
    /// Create a student as JSON
    /// </summary>
    /// <param name="student">The student object to create for</param>
    /// <remarks>The API return bad request if id less or equal to 0</remarks>
    /// <returns>No content method</returns>
    /// <response code="204">Returns no content that means successfully created student</response>
    /// <response code="400">If id less or equal to zero</response>
    [HttpPost]
    public IActionResult CreateStudent([FromBody] Student student)
    {
        if (student.Id <= 0)
        {
            return BadRequest("Id must be positive");
        }

        var students = _studentRepository.GetStudents();

        if (students.FirstOrDefault(s => s.Id == student.Id) != null)
            return BadRequest("Student with that id already exist");

        _studentRepository.CreateStudent(student);
        return NoContent();
    }

    /// <summary>
    /// Update a student by id
    /// </summary>
    /// <param name="id">The id to search for</param>
    /// <param name="student">The new student object to update for exist student</param>
    /// <remarks>The API return not found if that id does not exist</remarks>
    /// <returns>No content method</returns>
    /// <response code="204">Returns no content</response>
    /// <response code="404">If student not found</response>
    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, [FromBody] Student student)
    {
        var existStudent = _studentRepository.GetStudents().Where(s => s.Id == id);

        if (!existStudent.Any())
        {
            return NotFound();
        }

        _studentRepository.UpdateStudent(id, student);
        return NoContent();
    }

    /// <summary>
    /// Delete a student by id
    /// </summary>
    /// <param name="id">The id to search for</param>
    /// <remarks>The API return not found if that id does not exist</remarks>
    /// <response code="204">Returns no content</response>
    /// <response code="404">If student not found</response>
    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var existStudent = _studentRepository.GetStudents().Where(s => s.Id == id);

        if (!existStudent.Any())
        {
            return NotFound();
        }

        _studentRepository.DeleteStudent(id);
        return NoContent();
    }
}
