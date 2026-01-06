namespace MyProject.Domain.Entities;

/// <summary>
/// Representa un usuario del sistema
/// </summary>
public class User
{
    /// <summary>
    /// Identificador único del usuario
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Nombre del usuario
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Correo electrónico del usuario
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Órdenes asociadas al usuario
    /// </summary>
    public ICollection<Order> Orders { get; private set; } = new List<Order>();

    /// <summary>
    /// Constructor privado requerido por EF Core
    /// </summary>
    private User() { }

    /// <summary>
    /// Crea un nuevo usuario
    /// </summary>
    /// <param name="name">Nombre del usuario</param>
    /// <param name="email">Correo electrónico del usuario</param>
    public User(string name, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
    }
}
