using System.Linq.Expressions;
using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IDiscussionService
{
    Task<IEnumerable<Discussion>> GetAllWithIncludesAsync(params Expression<Func<Discussion, object>>[] includes);

    
    Task<IEnumerable<Discussion>> GetAllDiscussionAsync();
    Task<Discussion> GetDiscussionByIdAsync(int id);
    Task CreateDiscussionAsync(Discussion discussion);
    Task<bool> UpdateDiscussionAsync(int id, Discussion discussion);
    Task<bool> DeleteDiscussionAsync(int id);
}