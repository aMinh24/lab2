﻿using Lab2.Entities;

namespace Lab2.Interfaces;

public interface IBlogPostService
{
    Task<IEnumerable<BlogPost>> GetAllBlogPostAsync();
    Task<BlogPost> GetBlogPostByIdAsync(int id); 
    Task CreateBlogPostAsync(BlogPost blogPost);
    Task<bool> UpdateBlogPostAsync(int id, BlogPost blogPost); 
    Task<bool> DeleteBlogPostAsync(int id);
}