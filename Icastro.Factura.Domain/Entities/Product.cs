namespace Icastro.Factura.Domain.Entities;

/// <summary>
/// Representa un producto disponible para la venta
/// </summary>
public class Product
{
    /// <summary>
    /// Identificador único del producto
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Precio del producto
    /// </summary>
    public decimal Price { get; private set; }

    /// <summary>
    /// Identificador de la categoría asociada
    /// </summary>
    public Guid CategoryId { get; private set; }

    /// <summary>
    /// Categoría a la que pertenece el producto
    /// </summary>
    public Category Category { get; private set; }

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private Product() { }

    /// <summary>
    /// Crea un nuevo producto
    /// </summary>
    /// <param name="name">Nombre del producto</param>
    /// <param name="price">Precio del producto</param>
    /// <param name="categoryId">Identificador de la categoría</param>
    public Product(string name, decimal price, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        CategoryId = categoryId;
    }
}
