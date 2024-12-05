using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IQuestionService
{
    Task<IEnumerable<Question>> GetAllQuestionAsync();
    Task<Question> GetQuestionByIdAsync(int id); 
    Task CreateQuestionAsync(Question question);
    Task<bool> UpdateQuestionAsync(int id, Question question); 
    Task<bool> DeleteQuestionAsync(int id);
}