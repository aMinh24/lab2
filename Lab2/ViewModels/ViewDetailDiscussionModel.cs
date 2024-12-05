using Lab2.Controllers;
using Lab2.Controllers;
using Lab2.Entities;

namespace Lab2.ViewModels
{
    public class ViewDetailDiscussionModel
    {
        public Discussion Discussion { get; set; }
        public List<TopUserDiscussion> TopUserDiscussions { get; set; }
    }
}
