namespace DKaiza.Web.Models;

public class Pago
{
    public int Id { get; set; }
    public int CitaId { get; set; } // [cite: 24]
    public Cita Cita { get; set; }
    public decimal MontoBruto { get; set; } // [cite: 25]
    public decimal Descuento { get; set; } // [cite: 25]
    public decimal MontoTotal { get; set; } // [cite: 25]
    public string MetodoPago { get; set; } // Efectivo, Tarjeta, Yape/Plin [cite: 26]
    public DateTime FechaPago { get; set; } = DateTime.Now; // [cite: 27]

    // Relaciones
    public ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();
}
