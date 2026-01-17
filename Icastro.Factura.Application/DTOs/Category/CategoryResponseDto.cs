namespace Icastro.Factura.Application.DTOs.Category;

/// <summary>
/// DTO utilizado para devolver la información de una categoría
/// </summary>
public class CategoryResponseDto
{
    /// <summary>
    /// Identificador único de la categoría
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Nombre de la categoría
    /// </summary>
    public string Name { get; set; } = null!;
}
