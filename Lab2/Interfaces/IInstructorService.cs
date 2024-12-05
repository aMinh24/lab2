using System.Linq.Expressions;
using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IInstructorService
{
    Task<IEnumerable<Instructor>> GetAllInstructorAsync();
    
    Task<IEnumerable<Instructor>> GetAllWithIncludesAsync(params Expression<Func<Instructor, object>>[] includes);

    Task<Instructor> GetInstructorByIdAsync(int id); 
    Task CreateInstructorAsync(Instructor instructor);
    Task<bool> UpdateInstructorAsync(int id, Instructor instructor); 
    Task<bool> DeleteInstructorAsync(int id);
}