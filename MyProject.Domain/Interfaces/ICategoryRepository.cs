using MyProject.Domain.Entities;

namespace MyProject.Domain.Interfaces;

/// <summary>
/// Define las operaciones disponibles para categorías
/// </summary>
public interface ICategoryRepository
{
    /// <summary>
    /// Obtiene todas las categorías
    /// </summary>
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(Guid id);
    Task AddAsync(Category category);
    Task UpdateAsync(Category category);
    Task DeleteAsync(Category category);
}
