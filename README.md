# HorarioClases

```mermaid
classDiagram

    ConPilaCartas <|-- CartasMesa
    ConPilaCartas <|-- Mazo
    CartasMesa --* Ronda
    Mazo --* Ronda
    Ronda --* IMezclador
    Jugadores --o Ronda
    Motor ..> Ronda


    class Aula{
        Guid IdAula
        string Ubicación
        int Capacidad
    }

    class Curso{
        Guid IdCurso
        int Año
        int Division
    }

    class Especialidad{
        Guid Especialidad
        string Nombre
    }

    class Horario{
        Guid IdHorario
        string DiaSemana
        int Hora
    }

    class Materia{
        Guid IdMateria
        string Nombre
    }

    class Profesor{
        Guid IdProfesor
        string Nombre
        string Email
    }

    class Turno{
        Guid IdTurno
        string Turnos
    }

    class Usuario{
        Guid IdUsuario
        string Nombre
        string Email
    }

