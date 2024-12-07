using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IPlatformService
{
    Task<IEnumerable<Platform>> GetAllPlatformAsync();
    Task<Platform> GetPlatformByIdAsync(int id); 
    Task CreatePlatformAsync(Platform platform);
    Task<bool> UpdatePlatformAsync(int id, Platform platform); 
    Task<bool> DeletePlatformAsync(int id);
}