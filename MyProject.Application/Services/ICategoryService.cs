using MyProject.Application.DTOs.Category;

namespace MyProject.Application.Services;

/// <summary>
/// Contrato del servicio de categorías
/// </summary>
public interface ICategoryService
{
    /// <summary>
    /// Obtiene todas las categorías
    /// </summary>
    Task<IEnumerable<CategoryResponseDto>> GetAllAsync();

    /// <summary>
    /// Obtiene una categoría por su identificador
    /// </summary>
    Task<CategoryResponseDto?> GetByIdAsync(Guid id);

    /// <summary>
    /// Crea una nueva categoría
    /// </summary>
    Task<CategoryResponseDto> CreateAsync(CreateCategoryDto dto);

    /// <summary>
    /// Actualiza una categoría existente
    /// </summary>
    Task<bool> UpdateAsync(Guid id, UpdateCategoryDto dto);

    /// <summary>
    /// Elimina una categoría
    /// </summary>
    Task<bool> DeleteAsync(Guid id);
}




