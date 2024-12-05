using System.ComponentModel.DataAnnotations;

namespace Lab2.Entities;

public class TypePath
{
    [Key]
    public int TypePathId { get; set; }
    public string Path { get; set; }
}