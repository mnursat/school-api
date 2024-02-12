using School.API.Enums;
using School.API.Models;

namespace School.API.Persistence;

public static class Data
{
    public readonly static List<Student> Students = new List<Student>()
    {
        new Student
            {
            Id = 1,
            Document = new Document
            {
                Id = 1,
                IdType = IdType.Id,
                FirstName = "John",
                SecondName = "Week",
                Patronymic = "Silver"
            },
            Cabinet = Cabinets[0],
            AverageRating = 1.9
            },
            new Student
            {
                Id = 2,
                Document = new Document
                {
                    Id = 2,
                    IdType = IdType.BirthCertificate,
                    FirstName = "Leanne",
                    SecondName = "Graham",
                    Patronymic = "Bret"
                },
                Cabinet = Cabinets[0],
                AverageRating = 2.8
            },
            new Student
            {
                Id = 3,
                Document = new Document
                {
                    Id = 3,
                    IdType = IdType.BirthCertificate,
                    FirstName = "Ervin",
                    SecondName = "Howell",
                    Patronymic = "Antonette"
                },
                Cabinet = Cabinets[0],
                AverageRating = 3.11
            },
            new Student
            {
                Id = 4,
                Document = new Document
                {
                    Id = 4,
                    IdType = IdType.Passport,
                    FirstName = "Clementine",
                    SecondName = "Bauch",
                    Patronymic = "Samantha"
                },
                Cabinet = Cabinets[1],
                AverageRating = 3.33
            },
            new Student
            {
                Id = 5,
                Document = new Document
                {
                    Id = 5,
                    IdType = IdType.BirthCertificate,
                    FirstName = "Patricia",
                    SecondName = "Lebsack",
                    Patronymic = "Karianne"
                },
                Cabinet = Cabinets[1],
                AverageRating = 3.2
            },
            new Student
            {
                Id = 6,
                Document = new Document
                {
                    Id = 6,
                    IdType = IdType.Id,
                    FirstName = "Chelsey",
                    SecondName = "Dietrich",
                    Patronymic = "Kamren"
                },
                Cabinet = Cabinets[1],
                AverageRating = 3.99
            },
            new Student
            {
                Id = 7,
                Document = new Document
                {
                    Id = 7,
                    IdType = IdType.Passport,
                    FirstName = "Dennis",
                    SecondName = "Schulist",
                    Patronymic = "Leopoldo"
                },
                Cabinet = Cabinets[2],
                AverageRating = 3.91
            },
            new Student
            {
                Id = 8,
                Document = new Document
                {
                    Id = 8,
                    IdType = IdType.Id,
                    FirstName = "Kurtis",
                    SecondName = "Weissnat",
                    Patronymic = "Elwyn"
                },
                Cabinet = Cabinets[2],
                AverageRating = 3.6
            },
            new Student
            {
                Id = 9,
                Document = new Document
                {
                    Id = 9,
                    IdType = IdType.Id,
                    FirstName = "Nicholas",
                    SecondName = "Runolfsdottir",
                    Patronymic = "Nienow"
                },
                Cabinet = Cabinets[2],
                AverageRating = 3.0
            },
            new Student
            {
                Id = 10,
                Document = new Document
                {
                    Id = 10,
                    IdType = IdType.BirthCertificate,
                    FirstName = "Glenna",
                    SecondName = "Reichert",
                    Patronymic = "Delphine"
                },
                Cabinet = Cabinets[3],
                AverageRating = 2.81
            }
    };
    public readonly static List<Employee> Employees = new List<Employee>()
    {
        new Employee
        {
            Id = 1,
            Document = new Document
            {
                Id = 1,
                IdType = IdType.Passport,
                FirstName = "Cello",
                SecondName = "Aisbett",
                Patronymic = "Mia"
            },
            JobTitle = "Teacher"
        },
        new Employee
        {
            Id = 2,
            Document = new Document
            {
                Id = 2,
                IdType = IdType.Passport,
                FirstName = "Nortcliffe",
                SecondName = "Teriann",
                Patronymic = "Manser"
            },
            JobTitle = "Teacher"
        },
        new Employee
        {
            Id = 3,
            Document = new Document
            {
                Id = 3,
                IdType = IdType.Passport,
                FirstName = "Oates",
                SecondName = "Sich",
                Patronymic = "Barrett"
            },
            JobTitle = "Teacher"
        },
        new Employee
        {
            Id = 4,
            Document = new Document
            {
                Id = 4,
                IdType = IdType.Id,
                FirstName = "Ashley",
                SecondName = "Gimenez",
                Patronymic = "Shelby"
            },
            JobTitle = "Director"
        },
        new Employee
        {
            Id = 5,
            Document = new Document
            {
                Id = 5,
                IdType = IdType.BirthCertificate,
                FirstName = "Blenkinsop",
                SecondName = "Alma",
                Patronymic = "Gimson"
            },
            JobTitle = "Staff"
        }
    };

    public static List<Class> Classes
    {
        get
        {
            return new List<Class>
            {
                new Class { Id = 1, Name = "1A",Cabinet = Cabinets[0], Students = new List<Student>
                {
                    Students[0],
                    Students[1],
                    Students[2],
                    Students[5]
                } },
                new Class { Id = 1, Name = "1B",Cabinet = Cabinets[1], Students = new List<Student>
                {
                    Students[3],
                    Students[4],
                    Students[5]
                }
            },
            };
        }
    }

    public static List<Cabinet> Cabinets
    {
        get
        {
            return new List<Cabinet>()
            {
                new Cabinet { Id = 1, Name = "Math", Number = 1, Build = 1, Floor = 1 },
                new Cabinet { Id = 2, Name = "Literature", Number = 2, Build = 2, Floor = 1 },
                new Cabinet { Id = 3, Name = "Physics", Number = 3, Build = 1, Floor = 1 },
                new Cabinet { Id = 4, Name = "Gym", Number = 4, Build = 1, Floor = 2 },
                new Cabinet { Id = 5, Name = "Chemistry", Number = 5, Build = 2, Floor = 3 },
            };
        }
    }

    public static void CreateStudent(Student student)
    {
        Students.Add(student);
    }

    public static void CreateEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}