﻿namespace Lab2.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string InstructorName { get; set; } // To hold the instructor's name
        public string Description { get; set; }
        public string Thumbnail { get; set; }

        // Add other properties as needed from the Course model
    }
}