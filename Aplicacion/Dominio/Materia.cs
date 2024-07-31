namespace Aplicacion.Dominio;

public class Materia
{
    public Guid IdMateria { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
}
