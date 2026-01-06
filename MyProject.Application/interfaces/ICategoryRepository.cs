using MyProject.Domain.Entities;

namespace MyProject.Application.Interfaces;

/// <summary>
/// Define las operaciones disponibles para categorías
/// </summary>
public interface ICategoryRepository
{
    /// <summary>
    /// Obtiene todas las categorías
    /// </summary>
    Task<IEnumerable<Category>> GetAllAsync();
    Task AddAsync(Category category);
}
