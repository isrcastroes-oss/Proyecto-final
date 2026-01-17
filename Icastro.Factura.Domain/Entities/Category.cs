namespace Icastro.Factura.Domain.Entities;

/// <summary>
/// Representa una categoría de productos
/// </summary>
public class Category
{
    /// <summary>
    /// Identificador único de la categoría
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Nombre de la categoría
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private Category() { }

    /// <summary>
    /// Crea una nueva categoría
    /// </summary>
    /// <param name="name">Nombre de la categoría</param>
    public Category(string name)
    {
        Id = Guid.NewGuid();
        UpdateName(name);
    }

    /// <summary>
    /// Actualiza el nombre de la categoría
    /// </summary>
    /// <param name="name">Nuevo nombre</param>
    public void UpdateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre no puede estar vacío");

        Name = name;
    }
}
