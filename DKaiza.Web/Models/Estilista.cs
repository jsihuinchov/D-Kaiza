namespace DKaiza.Web.Models;

public class Estilista
{
    public int Id { get; set; }
    public string UsuarioId { get; set; } // [cite: 14]
    public ApplicationUser Usuario { get; set; }
    public string Especialidad { get; set; } // [cite: 15]
    public string FotoUrl { get; set; } // [cite: 15]
    public ICollection<HorarioLaboral> Horarios { get; set; } = new List<HorarioLaboral>();
    public ICollection<Cita> Citas { get; set; } = new List<Cita>();
}