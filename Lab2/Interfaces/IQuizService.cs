using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IQuizService
{
    Task<IEnumerable<Quiz>> GetAllQuizAsync();
    Task<Quiz> GetQuizByIdAsync(int id); 
    Task CreateQuizAsync(Quiz quiz);
    Task<bool> UpdateQuizAsync(int id, Quiz quiz); 
    Task<bool> DeleteQuizAsync(int id);
}