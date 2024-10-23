using Lab2.Models;

namespace Lab2.ViewModels
{
    public class LessonViewModel
    {
        public int Id { get; set; }
        public String LessonName { get; set; }
        public String CourseTitle { get; set; }
        public String InstructorName { get; set; }
        public String InstructorAvatar { get; set; }
        public String UrlVideo { get; set; }
        public String Description { get; set; }
        public String Duration { get; set; }
        public ICollection<Discussion> Discussions { get; set; }

    }
}
