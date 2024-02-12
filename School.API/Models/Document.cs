using School.API.Enums;

namespace School.API.Models;

public class Document
{
    public int Id { get; set; }
    public IdType IdType { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Patronymic { get; set; }
}