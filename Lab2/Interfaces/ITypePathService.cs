using Lab2.Entities;

namespace Lab2.Interfaces;

public interface ITypePathService
{
    Task<IEnumerable<TypePath>> GetAllTypePathAsync();
    Task<TypePath> GetTypePathByIdAsync(int id); 
    Task CreateTypePathAsync(TypePath typePath);
    Task<bool> UpdateTypePathAsync(int id, TypePath typePath); 
    Task<bool> DeleteTypePathAsync(int id);
}