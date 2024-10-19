using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class DataSeeder
{
    private readonly AppDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public DataSeeder(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task SeedDataAsync()
    {
        var roleNames = typeof(RoleName).GetFields();
        foreach (var role in roleNames)
        {
            string roleName = (string)role.GetRawConstantValue();
            var roleFound = await _roleManager.FindByNameAsync(roleName);
            if (roleFound == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        var userAdmin = await _userManager.FindByEmailAsync("instructor@example.com");
        if (userAdmin == null)
        {
            userAdmin = new AppUser
            {
                Name = "admin",
                Avatar = "~/images/people/50/guy-6.jpg",
                UserName = "admin",
                Email = "admin@example.com",

            };
            await _userManager.CreateAsync(userAdmin, "Password123!"); // Remember to hash passwords in production
            await _userManager.AddToRoleAsync(userAdmin, RoleName.Administrator);
        }
        if (!userAdmin.EmailConfirmed)
        {
            _context.SaveChangesAsync();
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(userAdmin);
            await _userManager.ConfirmEmailAsync(userAdmin, token);
            _context.SaveChanges();
            Console.WriteLine("Confirm Mail success");
        }

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
            await _userManager.AddToRoleAsync(instructor, RoleName.Instructor);

        }
        if (!instructor.EmailConfirmed)
        {
            _context.SaveChangesAsync();
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(instructor);
            await _userManager.ConfirmEmailAsync(instructor, token);
            _context.SaveChanges();
            Console.WriteLine("Confirm Mail success");
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
            await _userManager.AddToRoleAsync(student, RoleName.Student);

        }
        if (!student.EmailConfirmed)
        {
            _context.SaveChangesAsync();
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(student);
            await _userManager.ConfirmEmailAsync(student, token);
            _context.SaveChanges();
            Console.WriteLine("Confirm Mail success");
        }
        if (!(_context.Courses.Any()))
        {
            var platforms = await _context.Platforms.ToListAsync();
            var topics = await _context.Topics.ToListAsync();
            instructor = await _userManager.FindByEmailAsync("instructor@example.com");
            var teacher = new Instructor()
            {
                UserId = instructor.Id,
                About = "Minh chúa quỷ 1 2 3 4",
                LinkFacebook = "https://www.facebook.com/minh2k4z",
                LinkTwitter = "123",
                Avatar = "123"
            };

            _context.Instructors.Add(teacher);
            await _context.SaveChangesAsync();
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
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Adobe XD",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/xd_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "inVision App",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/invision_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Craft by inVision",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,
                        TopicId = topics.First(p => p.Name == "Web Development").TopicId,
                        Thumbnail = "~/images/paths/craft_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Learn Angular fundamentals",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.",
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId,     // Replace with actual TopicId
                        Thumbnail = "~/images/paths/angular_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now

                    },
                    new Course
                    {
                        Title = "Build an iOS Application in Swift",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,  // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Mobile Development").TopicId, // Replace with actual TopicId
                        Thumbnail = "~/images/paths/swift_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Build a WordPress Website",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId,  // Replace with actual TopicId
                        Thumbnail = "~/images/paths/wordpress_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Become a React Native Developer",
                        Description = "Learn the fundamentals of working with Angular and how to create basic applications.", // Update description if needed
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with actual PlatformId
                        TopicId = topics.First(t => t.Name == "Mobile Development").TopicId, // Replace with actual TopicId
                        Thumbnail = "~/images/paths/react_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Learn Sketch",
                        Description = "Learn the fundamentals of working with Sketch.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/sketch_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                    new Course
                    {
                        Title = "Learn Flinto",
                        Description = "Learn the fundamentals of working with Flinto.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId,  // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/flinto_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                     new Course
                    {
                        Title = "Learn Photoshop",
                        Description = "Learn the fundamentals of working with Photoshop.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/photoshop_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
                    },
                      new Course
                    {
                        Title = "Learn Figma",
                        Description = "Learn the fundamentals of working with Figma.", // Update description
                        InstructorId = instructor.Id,
                        PlatformId = platforms.First(p => p.Name == "Udemy").PlatformId, // Replace with your PlatformId
                        TopicId = topics.First(t => t.Name == "Web Development").TopicId, // Replace with your TopicId
                        Thumbnail = "~/images/paths/figma_430x168.png",
                        TrailerUrl = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                        Date = DateTime.Now
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
                Title = "Getting Started With Angular",
                OrderChap = 1,
                Description = "Good tools make application development quick*er and easier to maintain than* if you did everything by hand. The goal in this guide is to build and run a simple Angular application in TypeScript, using the Angular CLI while adhering to the Style Guide recommendations that benefit every Angular project.",
                Course = course,

            };
            course.Chapters.Add(chapter);
            _context.Chapters.Add(chapter);

            chapter = new Chapter
            {
                CourseId = course.CourseId,
                Title = "Creating and Communicating Between Angular Components",
                OrderChap = 2,
                Description = "Data sharing is an essential concept to understand before diving into your first Angular project. In this section, you will learn four different methods for sharing data between Angular components.",
                Course = course,

            };
            course.Chapters.Add(chapter);
            _context.Chapters.Add(chapter);
            await _context.SaveChangesAsync();
        }
        if (!(_context.Lessons.Any()))
        {
            var course = _context.Courses.Include(c => c.Chapters).FirstOrDefault(c => c.Title == "Learn Angular fundamentals");
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

            lesson = new Lesson
            {
                ChapterId = chap.ChapterId,
                Chapter = chap,
                Title = "Introduction to JavaScript",
                VideoUrl = "https://www.youtube.com/watch?v=5gO0xpY_Y3E&t=1s",
                Description = "JavaScript is now used to power backends, create hybrid mobile applications, architect cloud solutions, design neural networks and even control robots. Enter TypeScript: a superset of JavaScript for scalable, secure, performant and feature-rich applications.",
                EstimateTime = 181,
                OrderLesson = 1,
            };
            chap.Lessons.Add(lesson);
            _context.Lessons.Add(lesson);
            lesson = new Lesson
            {
                ChapterId = chap.ChapterId,
                Chapter = chap,
                Title = "Compare Angular and AngularJS",
                VideoUrl = "https://www.youtube.com/embed/4Ad-f9fUnto?si=2AEhf53XsoWjWvvB",
                Description = "So Sánh HEHHEHEHEHEHHEH MINHHHHH",
                EstimateTime = 366,
                OrderLesson = 2,
            };
            chap.Lessons.Add(lesson);
            _context.Lessons.Add(lesson);

            chap = course.Chapters.Skip(1).First();
            lesson = new Lesson
            {
                ChapterId = chap.ChapterId,
                Chapter = chap,
                Title = "Compare Angular and AngularJS",
                VideoUrl = "https://www.youtube.com/embed/4Ad-f9fUnto?si=2AEhf53XsoWjWvvB",
                Description = "So Sánh HEHHEHEHEHEHHEH MINHHHHH",
                EstimateTime = 366,
                OrderLesson = 2,
            };
            chap.Lessons.Add(lesson);
            _context.Lessons.Add(lesson);

            lesson = new Lesson
            {
                ChapterId = chap.ChapterId,
                Chapter = chap,
                Title = "Introduction to JavaScript",
                VideoUrl = "https://www.youtube.com/watch?v=5gO0xpY_Y3E&t=1s",
                Description = "JavaScript is now used to power backends, create hybrid mobile applications, architect cloud solutions, design neural networks and even control robots. Enter TypeScript: a superset of JavaScript for scalable, secure, performant and feature-rich applications.",
                EstimateTime = 181,
                OrderLesson = 1,
            };
            chap.Lessons.Add(lesson);
            _context.Lessons.Add(lesson);
            _context.SaveChanges();
        }
        if (!_context.SubscriptionTypes.Any())
        {
            _context.SubscriptionTypes.AddRange(new List<SubscriptionType> {
                new SubscriptionType
                {
                    Name = "Free",
                    Price = 0,
                    Duration = -1,
                },
                new SubscriptionType
                {
                    Name = "Student",
                    Price = 9,
                    Duration = 1,
                },
                new SubscriptionType
                {
                    Name = "Team",
                    Price = 19,
                    Duration = 1,
                },
                new SubscriptionType
                {
                    Name = "Enterprise",
                    Price = 49,
                    Duration = 1,
                }
            });
            _context.SaveChanges();
        }
        if (!_context.Subscriptions.Any())
        {
            var typeSub = await _context.SubscriptionTypes.FirstAsync();
            List<Subscription> subs = new List<Subscription>();
            foreach (var user in _context.Users)
            {
                subs.Add(new Subscription
                {
                    SubscriptionTypeId = typeSub.SubscriptionTypeId,
                    UserId = user.Id,
                    User = user,
                    SubscriptionType = typeSub,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(360)
                });
            }
            _context.Subscriptions.AddRange(subs);
            _context.SaveChanges();
        }
        if (!_context.PaymentInformations.Any())
        {
            _context.PaymentInformations.Add(new PaymentInformation
            {
                AutoRenew = true,
                UserId = student.Id,
                User = student,
                CreditNumber = "12345567890",
            });
            _context.SaveChanges();
        }
    }

}
