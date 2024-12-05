using System.Linq.Expressions;
using Lab2.Entities;

namespace Lab2.Interfaces;

public interface ILessonService
{

    Task<IEnumerable<Lesson>> GetAllWithIncludesAsync(params Expression<Func<Lesson, object>>[] includes);
    Task<IEnumerable<Lesson>> GetAllLessonAsync();
    Task<Lesson> GetLessonByIdAsync(int id); 
    Task CreateLessonAsync(Lesson lesson);
    Task<bool> UpdateLessonAsync(int id, Lesson lesson); 
    Task<bool> DeleteLessonAsync(int id);
}