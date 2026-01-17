namespace Icastro.Factura.Domain.Entities;

/// <summary>
/// Representa un ítem dentro de una orden
/// </summary>
public class OrderItem
{
    /// <summary>
    /// Identificador único del ítem
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Identificador de la orden
    /// </summary>
    public Guid OrderId { get; private set; }

    /// <summary>
    /// Orden asociada
    /// </summary>
    public Order Order { get; private set; }

    /// <summary>
    /// Identificador del producto
    /// </summary>
    public Guid ProductId { get; private set; }

    /// <summary>
    /// Producto asociado
    /// </summary>
    public Product Product { get; private set; }

    /// <summary>
    /// Cantidad del producto
    /// </summary>
    public int Quantity { get; private set; }

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private OrderItem() { }

    /// <summary>
    /// Crea un nuevo ítem de orden
    /// </summary>
    /// <param name="orderId">Identificador de la orden</param>
    /// <param name="productId">Identificador del producto</param>
    /// <param name="quantity">Cantidad del producto</param>
    public OrderItem(Guid orderId, Guid productId, int quantity)
    {
        Id = Guid.NewGuid();
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
    }
}
