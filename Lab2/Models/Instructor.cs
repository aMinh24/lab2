
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Lab2.Models
{
    public class Instructor
    {

        [Key]
        public int InstructorId { get; set; }
        
        [ForeignKey("AppUser")]
        public string UserId { get; set; }

        public string About { get; set; }
        public string LinkFacebook { get; set; }
        public string LinkTwitter { get; set; }
        public string Avatar { get; set; }
        public int? TopicId { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic PrimaryTopic { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
