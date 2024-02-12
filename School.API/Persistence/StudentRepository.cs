using School.API.Models;

namespace School.API.Persistence;

public class StudentRepository : IStudentRepository
{
    public void CreateStudent(Student student)
    {
        Data.CreateStudent(student);
    }

    public void DeleteStudent(int id)
    {
        Data.Students.Remove(Data.Students[id - 1]);
    }

    public IEnumerable<Student> GetStudents()
    {
        return Data.Students;
    }

    public IEnumerable<Student> GetStudentsByClass(string className)
    {
        var selecetedClass = Data.Classes.Where(s => s.Name == className).ToList();
        var students = selecetedClass.Select(s => s.Students).FirstOrDefault();
        return students;
    }

    public void UpdateStudent(int id, Student student)
    {
        Data.Students[id - 1] = student;
    }
}
