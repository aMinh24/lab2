using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }
        public string TrailerUrl { get; set; }
        [Required]
        public string InstructorId { get; set; }
        [Required]
        public int TopicId { get; set; }
        [Required]
        public int PlatformId { get; set; }
        public string Thumbnail { get; set; }
        public DateTime? Date { get; set; }

        public double? Duration { get; set; }
        [NotMapped]
        public double? AverageRating { get; set; }
        
        
        [ForeignKey("InstructorId")]
        public virtual AppUser Instructor { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }

        [ForeignKey("PlatformId")]
        public virtual Platform Platform { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }

        public Course()
        {
            Chapters = new List<Chapter>();
            Discussions = new List<Discussion>();
            UserCourses = new List<UserCourse>();
        }
    }
}
