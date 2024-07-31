namespace Aplicacion.Dominio;

public class Curso
{
    public Guid IdCurso { get; set; } = Guid.NewGuid();
    public int Año { get; set; }
    public int Division { get; set; }
}
