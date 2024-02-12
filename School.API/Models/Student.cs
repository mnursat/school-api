using System.ComponentModel.DataAnnotations;

namespace School.API.Models;

public class Student
{
    [Required]
    public int Id { get; set; }

    [Required]
    public Document Document { get; set; }

    [Required]
    public Cabinet Cabinet { get; set; }

    [Required]
    public double AverageRating { get; set; }
}