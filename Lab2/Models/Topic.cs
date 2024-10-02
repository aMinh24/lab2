using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public Topic()
        {
            Courses = new List<Course>();
        }
    }
}
