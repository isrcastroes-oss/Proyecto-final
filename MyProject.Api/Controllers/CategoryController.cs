using Microsoft.AspNetCore.Mvc;
using MyProject.Application.DTOs.Category;
using MyProject.Application.Services;

namespace MyProject.Api.Controllers;

/// <summary>
/// Controlador para la gestión de categorías
/// </summary>
[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;

    /// <summary>
    /// Inicializa el controlador de categorías
    /// </summary>
    /// <param name="service">Servicio de categorías</param>
    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    /// <summary>
    /// Obtiene todas las categorías
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.GetAllAsync());
    }

    /// <summary>
    /// Obtiene una categoría por su ID
    /// </summary>
    /// <param name="id">Identificador de la categoría</param>
    /// <returns>Categoría encontrada</returns>
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var category = await _service.GetByIdAsync(id);
        if (category == null)
            return NotFound();

        return Ok(category);
    }

    /// <summary>
    /// Crea una nueva categoría
    /// </summary>
    /// <param name="dto">Datos de la categoría</param>
    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryDto dto)
    {
        var result = await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result
        );
    }

    /// <summary>
    /// Actualiza una categoría existente
    /// </summary>
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateCategoryDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        if (!updated)
            return NotFound();

        return NoContent();
    }

    /// <summary>
    /// Elimina una categoría
    /// </summary>
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
