namespace Aplicacion.Dominio;

public class Usuario
{
    public Guid IdUsuario { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}