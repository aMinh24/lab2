using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IMenuService
{
    Task<IEnumerable<Menu>> GetAllMenuAsync();
    Task<Menu> GetMenuByIdAsync(int id); 
    Task CreateMenuAsync(Menu menu);
    Task<bool> UpdateMenuAsync(int id, Menu menu); 
    Task<bool> DeleteMenuAsync(int id);
}