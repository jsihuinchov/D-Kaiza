namespace DKaiza.Web.Models;

public class Cliente
{
    public int Id { get; set; }
    public string UsuarioId { get; set; } // [cite: 5]
    public ApplicationUser Usuario { get; set; }
    public string HistorialNotas { get; set; } // [cite: 6]
    public bool Estado { get; set; } = true; // [cite: 7]

    // Relaciones
    public ICollection<Cita> Citas { get; set; } = new List<Cita>();
}

