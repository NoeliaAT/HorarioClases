namespace Aplicacion.Dominio;

public class Especialidad
{
    public Guid IdEspecialidad { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
}