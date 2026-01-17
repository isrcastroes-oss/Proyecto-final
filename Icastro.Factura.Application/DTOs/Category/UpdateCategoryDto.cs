using System.ComponentModel.DataAnnotations;

namespace Icastro.Factura.Application.DTOs.Category;

/// <summary>
/// DTO utilizado para actualizar una categoría existente
/// </summary>
public class UpdateCategoryDto
{
    /// <summary>
    /// Nuevo nombre de la categoría
    /// </summary>
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(
        50,
        MinimumLength = 6,
        ErrorMessage = "El nombre debe tener entre 6 y 50 caracteres"
    )]
    public string Name { get; set; } = string.Empty;
}
