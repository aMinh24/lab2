
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Lab2.Models
{
    public class Student
    {
            [Key]
            public int StudentId { get; set; }
        
            [ForeignKey("AppUser")]
            public string UserId { get; set; }

            public string? LinkFacebook { get; set; }
            public string? LinkTwitter { get; set; }
            public string? Avatar { get; set; }
            public string? Role { get; set; }
            public string? School { get; set; }
            public virtual AppUser AppUser { get; set; }
        }
    }    


