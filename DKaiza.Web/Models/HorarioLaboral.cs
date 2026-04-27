namespace DKaiza.Web.Models;

public class HorarioLaboral
{
    public int Id { get; set; }
    public int EstilistaId { get; set; } // [cite: 16]
    public DayOfWeek DiaSemana { get; set; } // [cite: 17]
    public TimeSpan HoraInicio { get; set; } // [cite: 17]
    public TimeSpan HoraFin { get; set; } // [cite: 17]

    // Relaciones
    public Estilista Estilista { get; set; }
}