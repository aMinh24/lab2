using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2.Entities;
public class LearningOutcomes
{
    [Key]
    public int LearningOutcomesId { get; set; }
    
    
    public int CourseId { get; set; }
    [ForeignKey("CourseId")]
    public virtual Course Course { get; set; }
    
    public string Outcome { get; set; }
}