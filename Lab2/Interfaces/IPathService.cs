using System.Linq.Expressions;
using Lab2.Entities;
using Path = Lab2.Entities.Path;

namespace Lab2.Interfaces;

public interface IPathService
{
    Task<IEnumerable<Path>> GetAllWithIncludesAsync(params Expression<Func<Path, object>>[] includes);

    Task<IEnumerable<Path>> GetAllPathAsync();
    Task<Path> GetPathByIdAsync(int id); 
    Task CreatePathAsync(Path path);
    Task<bool> UpdatePathAsync(int id, Path path); 
    Task<bool> DeletePathAsync(int id);
}