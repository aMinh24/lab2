using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2.Models;

public class StudentPath
{
    [Key] public int StudentPathId { get; set; }
    public int StudentId { get; set; }
    public int PathId { get;set; }
    public int? Rating { get; set; }
    [ForeignKey("StudentId")] public virtual Student Student { get; set; }
    [ForeignKey("PathId")] public virtual Path Path { get; set; }
}