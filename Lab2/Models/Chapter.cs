﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public int OrderChap { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }

        public Chapter()
        {
            Lessons = new List<Lesson>();
        }
    }
}