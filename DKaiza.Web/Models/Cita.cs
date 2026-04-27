namespace DKaiza.Web.Models;

public class Cita
{
    public int Id { get; set; }
    public DateTime FechaHoraInicio { get; set; }
    public DateTime FechaHoraFin { get; set; }
    public string Estado { get; set; } // Pendiente, Confirmada, Finalizada, Cancelada
    public string Comentarios { get; set; }

    public int ClienteId { get; set; }
    public int EstilistaId { get; set; }
    public int ServicioId { get; set; }
    
    // Propiedades de navegación
    public Cliente Cliente { get; set; }
    public Estilista Estilista { get; set; }
    public Servicio Servicio { get; set; }
    public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}