using System.ComponentModel.DataAnnotations;

namespace MyProject.Application.DTOs.Category;

/// <summary>
/// DTO utilizado para crear una nueva categoría
/// </summary>
public class CreateCategoryDto
{
    /// <summary>
    /// Nombre de la categoría a crear
    /// </summary>
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(
        50,
        MinimumLength = 6,
        ErrorMessage = "El nombre debe tener entre 6 y 50 caracteres"
    )]
    public string Name { get; set; } = string.Empty;
}
