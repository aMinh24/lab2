using Lab2.Entities;

namespace Lab2.ViewModels
{
    public class StudentCourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public Course Course { get; set; }
        public FeedbackViewModel Feedback { get; set; }
    }

    public class FeedbackViewModel
    {
        public string? Comment { get; set; }
        public int Rating { get; set; }
    }
}