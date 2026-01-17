namespace Icastro.Factura.Domain.Entities;

/// <summary>
/// Representa una orden realizada por un usuario
/// </summary>
public class Order
{
    /// <summary>
    /// Identificador único de la orden
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Fecha de creación de la orden
    /// </summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// Identificador del usuario que realizó la orden
    /// </summary>
    public Guid UserId { get; private set; }

    /// <summary>
    /// Usuario asociado a la orden
    /// </summary>
    public User User { get; private set; }

    /// <summary>
    /// Lista de productos incluidos en la orden
    /// </summary>
    public ICollection<OrderItem> Items { get; private set; } = new List<OrderItem>();

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private Order() { }

    /// <summary>
    /// Crea una nueva orden para un usuario
    /// </summary>
    /// <param name="userId">Identificador del usuario</param>
    public Order(Guid userId)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        CreatedAt = DateTime.UtcNow;
    }
}
