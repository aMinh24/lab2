using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Models
{
    public class AppUser : IdentityUser
    {

        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<Course> CoursesInstructed { get; set; } // Courses where this user is the instructor
        public virtual ICollection<Discussion> DiscussionsStarted { get; set; }
        public virtual ICollection<DiscussionReply> DiscussionReplies { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<UserLesson> UserLessons { get; set; }

        public AppUser()
        {
            BlogPosts = new List<BlogPost>();
            CoursesInstructed = new List<Course>();
            DiscussionsStarted = new List<Discussion>();
            DiscussionReplies = new List<DiscussionReply>();
            Subscriptions = new List<Subscription>();
            UserCourses = new List<UserCourse>();
            UserLessons = new List<UserLesson>();
        }
    }
}
