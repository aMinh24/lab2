using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IDiscussionReplyService
{
    Task<IEnumerable<DiscussionReply>> GetAllDiscussionReplyAsync();
    Task<DiscussionReply> GetDiscussionReplyByIdAsync(int id); 
    Task CreateDiscussionReplyAsync(DiscussionReply discussionReply);
    Task<bool> UpdateDiscussionReplyAsync(int id, DiscussionReply discussionReply); 
    Task<bool> DeleteDiscussionReplyAsync(int id);
}