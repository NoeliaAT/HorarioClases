namespace Aplicacion.Dominio;

public class Horario
{
    public Guid IdHorario { get; set; } = Guid.NewGuid();
    public string DiaSemana { get; set; } = string.Empty;
    public int Hora { get; set; }
}
