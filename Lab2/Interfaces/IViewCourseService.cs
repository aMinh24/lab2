using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IViewCourseService
{
    Task<IEnumerable<ViewCourse>> GetAllViewCourseAsync();
    Task<ViewCourse> GetViewCourseByIdAsync(int id); 
    Task<ViewCourse> CreateViewCourseAsync(ViewCourse viewCourse);
    Task<bool> UpdateViewCourseAsync(int id, ViewCourse viewCourse); 
    Task<bool> DeleteViewCourseAsync(int id);
}