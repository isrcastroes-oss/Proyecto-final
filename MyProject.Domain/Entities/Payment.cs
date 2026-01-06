namespace MyProject.Domain.Entities;

/// <summary>
/// Representa el pago de una orden
/// </summary>
public class Payment
{
    /// <summary>
    /// Identificador único del pago
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Identificador de la orden pagada
    /// </summary>
    public Guid OrderId { get; private set; }

    /// <summary>
    /// Orden asociada al pago
    /// </summary>
    public Order Order { get; private set; }

    /// <summary>
    /// Monto pagado
    /// </summary>
    public decimal Amount { get; private set; }

    /// <summary>
    /// Fecha en la que se realizó el pago
    /// </summary>
    public DateTime PaidAt { get; private set; }

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private Payment() { }

    /// <summary>
    /// Crea un nuevo pago
    /// </summary>
    /// <param name="orderId">Identificador de la orden</param>
    /// <param name="amount">Monto pagado</param>
    public Payment(Guid orderId, decimal amount)
    {
        Id = Guid.NewGuid();
        OrderId = orderId;
        Amount = amount;
        PaidAt = DateTime.UtcNow;
    }
}
