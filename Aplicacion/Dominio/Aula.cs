namespace Aplicacion.Dominio;

public class Aula
{
    public Guid IdAula { get; set; } = Guid.NewGuid();
    public string Ubicacion { get; set; } = string.Empty;
    public int Capacidad { get; set; }
}
