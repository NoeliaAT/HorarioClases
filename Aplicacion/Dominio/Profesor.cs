namespace Aplicacion.Dominio;

public class Profesor
{
    public Guid IdProfesor { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
