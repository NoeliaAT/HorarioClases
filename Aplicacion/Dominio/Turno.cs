namespace Aplicacion.Dominio;

public class Turno
{
    public Guid IdTurno { get; set; } = Guid.NewGuid();
    public string Turnos { get; set; } = string.Empty;
}
