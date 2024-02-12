using School.API.Models;

namespace School.API.Persistence;

public interface IStudentRepository
{
    public IEnumerable<Student> GetStudents();
    public IEnumerable<Student> GetStudentsByClass(string className);
    public void CreateStudent(Student student);
    public void UpdateStudent(int id, Student student);
    public void DeleteStudent(int id);
}
