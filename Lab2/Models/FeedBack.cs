using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class FeedBack
    {
        [Key]
        public int FeedBackId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CourseId { get; set; }



        [ForeignKey("UserId")]
        public virtual Student Student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        public int? Rating { get; set; }
        public string? Feedback { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
    }   
}