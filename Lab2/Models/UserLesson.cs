using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class UserLesson
    {
        [Key]
        public int UserLessonId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int LessonId { get; set; }

        [Required]
        public bool Completed { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }

        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }
    }
}
