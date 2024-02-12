namespace School.API.Models;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Cabinet Cabinet { get; set; }
    public IEnumerable<Student> Students { get; set; }
}