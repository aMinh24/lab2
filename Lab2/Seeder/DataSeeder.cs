using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class DataSeeder
{
    private readonly AppDbContext _context;
    private readonly UserManager<AppUser> _userManager;

    public DataSeeder(AppDbContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task SeedDataAsync()
    {
        if (!_context.Platforms.Any())
        {
            _context.Platforms.AddRange(
                new Platform { Name = "Udemy" },
                new Platform { Name = "Coursera" },
                new Platform { Name = "edX" }
            );
            await _context.SaveChangesAsync();
        }

        if (!_context.Topics.Any())
        {
            _context.Topics.AddRange(
                new Topic { Name = "Web Development" },
                new Topic { Name = "Data Science" },
                new Topic { Name = "Mobile Development" }
             );
            await _context.SaveChangesAsync();
        }


        var instructor = await _userManager.FindByEmailAsync("instructor@example.com");
        if (instructor == null)
        {
            instructor = new AppUser
            {
                Name = "Minh chúa quỷ",
                Avatar = "~/images/people/50/guy-6.jpg",
                UserName = "instructor@example.com",
                Email = "instructor@example.com",

            };
            await _userManager.CreateAsync(instructor, "Password123!"); // Remember to hash passwords in production
        }

        var student = await _userManager.FindByEmailAsync("student@example.com");
        if (student == null)
        {
            student = new AppUser
            {
                Name = "Minh Chúa tể",
                Avatar = "~/images/people/50/guy-3.jpg",
                UserName = "student@example.com",
                Email = "student@example.com",
            };
            await _userManager.CreateAsync(student, "Password123!");
        }

        if (!(_context.Courses.Any()))
        {
            var platforms = await _context.Platforms.ToListAsync();
            var topics = await _context.Topics.ToListAsync();
            var newCourses = new List<Course>
                {
                    new Course
                    {
                        Title = "Newsletter Design",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p=> p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p=> p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/mailchimp_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Adobe XD",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/xd_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "inVision App",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/invision_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Craft by inVision",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/craft_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Learn Angular fundamentals",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId,     // Replace with actual TopicId
                        Thumbnail = "~/images/paths/angular_430x168.png",
                                                TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"

                    },
                    new Course
                    {
                        Title = "Build an iOS Application in Swift",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,  // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Mobile Development").TopicId, // Replace with actual TopicId
                        Thumbnail = "~/images/paths/swift_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Build a WordPress Website",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId,  // Replace with actual TopicId
                        Thumbnail = "~/images/paths/wordpress_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Become a React Native Developer",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Mobile Development").TopicId, // Replace with actual TopicId
                        Thumbnail = "~/images/paths/react_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Learn Sketch",
                        Description = "Learn the fundamentals of working with Sketch.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/sketch_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                    new Course
                    {
                        Title = "Learn Flinto",
                        Description = "Learn the fundamentals of working with Flinto.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,  // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/flinto_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                     new Course
                    {
                        Title = "Learn Photoshop",
                        Description = "Learn the fundamentals of working with Photoshop.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/photoshop_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    },
                      new Course
                    {
                        Title = "Learn Figma",
                        Description = "Learn the fundamentals of working with Figma.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/figma_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm"
                    }
                };


            _context.Courses.AddRange(newCourses);
            await _context.SaveChangesAsync();
        }
        if (!_context.Chapters.Any())
        {
            var course = _context.Courses.FirstOrDefault(c => c.Title == "Learn Angular fundamentals");
            var chapter = new Chapter
            {
                CourseId = course.CourseId,
                Title = "Introduce",
                OrderChap = 1,
                Course = course,
                
            };
            course.Chapters.Add(chapter);
            _context.Chapters.Add(chapter);
            await _context.SaveChangesAsync();
        }
        if (!(_context.Lessons.Any()))
        {
            var course = _context.Courses.Include(c=>c.Chapters).FirstOrDefault(c => c.Title == "Learn Angular fundamentals");
            Chapter chap = course.Chapters.FirstOrDefault();
            Lesson lesson = new Lesson
            {
                ChapterId = chap.ChapterId,
                Chapter = chap,
                Title = "Introduction to Typescript",
                VideoUrl = "https://www.youtube.com/watch?v=5gO0xpY_Y3E&t=1s",
                Description = "JavaScript is now used to power backends, create hybrid mobile applications, architect cloud solutions, design neural networks and even control robots. Enter TypeScript: a superset of JavaScript for scalable, secure, performant and feature-rich applications.",
                EstimateTime = 181
            };
            chap.Lessons.Add(lesson);
            _context.Lessons.Add(lesson);
            _context.SaveChanges();
        }
    }



}