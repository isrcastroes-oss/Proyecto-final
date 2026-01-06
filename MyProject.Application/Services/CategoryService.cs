using MyProject.Application.DTOs.Category;
using MyProject.Domain.Entities;
using MyProject.Domain.Interfaces;

namespace MyProject.Application.Services;

/// <summary>
/// Servicio encargado de la lógica de negocio de categorías
/// </summary>
public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;

    /// <summary>
    /// Inicializa el servicio de categorías
    /// </summary>
    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// Obtiene todas las categorías
    /// </summary>
    public async Task<IEnumerable<CategoryResponseDto>> GetAllAsync()
    {
        var categories = await _repository.GetAllAsync();

        return categories.Select(c => new CategoryResponseDto
        {
            Id = c.Id,
            Name = c.Name
        });
    }

    /// <summary>
    /// Obtiene una categoría por su identificador
    /// </summary>
    public async Task<CategoryResponseDto?> GetByIdAsync(Guid id)
    {
        var category = await _repository.GetByIdAsync(id);
        if (category == null) return null;

        return new CategoryResponseDto
        {
            Id = category.Id,
            Name = category.Name
        };
    }

    /// <summary>
    /// Crea una nueva categoría
    /// </summary>
    public async Task<CategoryResponseDto> CreateAsync(CreateCategoryDto dto)
    {
        var category = new Category(dto.Name);
        await _repository.AddAsync(category);

        return new CategoryResponseDto
        {
            Id = category.Id,
            Name = category.Name
        };
    }

    /// <summary>
    /// Actualiza una categoría existente
    /// </summary>
    public async Task<bool> UpdateAsync(Guid id, UpdateCategoryDto dto)
    {
        var category = await _repository.GetByIdAsync(id);
        if (category == null) return false;

        category.UpdateName(dto.Name);
        await _repository.UpdateAsync(category);

        return true;
    }

    /// <summary>
    /// Elimina una categoría
    /// </summary>
    public async Task<bool> DeleteAsync(Guid id)
    {
        var category = await _repository.GetByIdAsync(id);
        if (category == null) return false;

        await _repository.DeleteAsync(category);
        return true;
    }
}
