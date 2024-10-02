using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class DiscussionReply
    {
        [Key]
        public int DiscussionReplyId { get; set; }

        [Required]
        public int DiscussionId { get; set; }

        [Required]
        public string UserId { get; set; }

        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("DiscussionId")]
        public virtual Discussion Discussion { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}
