using Lab2.Hub;
using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Lab2.Controllers
{
    public class DiscussionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public DiscussionController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(int id)
        {
            var disc = _context.Discussions.Include(d => d.User).Include(d => d.DiscussionReplies).Where(d => d.LessonId == id).OrderByDescending(d => d.CreatedAt).ToList();
            return View(disc);
        }
        public IActionResult Detail(int id)
        {
            var disc = _context.Discussions.Include(d => d.User).Include(d => d.DiscussionReplies.OrderByDescending(r=>r.CreatedAt)).ThenInclude(r => r.User).FirstOrDefault(d => d.DiscussionId == id);
            ViewDetailDiscussionModel viewDetailDiscussionModel = new ViewDetailDiscussionModel
            {
                Discussion = disc,
                TopUserDiscussions = GetTopDiscussionCreators(TimePeriod.ThisMonth)
            };
            return View(viewDetailDiscussionModel);
        }

        public IActionResult Ask()
        {
            return View();
        }

        public IActionResult Test() { return View(); }

        [HttpPost]
        [Route("Discussion/PostCommentAsync")]
        public async Task<IActionResult> PostCommentAsync(int discussionId, string content)
        {

            // Get the currently logged-in user
            var user = await _userManager.GetUserAsync(User);

            var rep = new DiscussionReply
            {
                DiscussionId = discussionId,
                Content = content,
                UserId = user.Id
            };

            _context.DiscussionReplies.Add(rep);
            _context.SaveChanges();

            // Return the necessary data for the AJAX response
            var result = new
            {
                userName = user.Name,
                userAvatar = Url.Content(user.Avatar), // Assuming you have an Avatar property on your User model
                content = content
            };
            //await _discussionHub.SendComment(discussionId, result.userName, result.userAvatar, result.content);
            Console.WriteLine("\n---Post success---\n");

            return Json(result); // Return JSON data to the client-side
        }
        public List<TopUserDiscussion> GetTopDiscussionCreators(TimePeriod period)
        {
            DateTime startDate;
            switch (period)
            {
                case TimePeriod.ThisMonth:
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    break;
                case TimePeriod.ThisWeek:
                    startDate = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek); // Beginning of the current week (Sunday)
                    break;
                case TimePeriod.ThisYear:
                    startDate = new DateTime(DateTime.Now.Year, 1, 1);
                    break;
                default:
                    throw new ArgumentException("Invalid time period specified.");
            }

            var topUsers = _context.Discussions.Include(d => d.User)
                .Where(d => d.CreatedAt >= startDate)
                .GroupBy(d => d.UserId)
                .Select(g => new TopUserDiscussion
                {
                    User = g.FirstOrDefault().User,
                    DiscussionCount = g.Count(),
                })
                .OrderByDescending(u => u.DiscussionCount)
                .Take(10) // Limit to top 10
                .ToList();

            return topUsers;
        }
    }
    public class TopUserDiscussion
    {
        public AppUser User { get; set; }
        public int DiscussionCount { get; set; }
    }

    public enum TimePeriod
    {
        ThisMonth,
        ThisWeek,
        ThisYear
    }
}
