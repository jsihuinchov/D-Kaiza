namespace DKaiza.Web.Models;

public class Comprobante
{
    public int Id { get; set; }
    public int PagoId { get; set; } // [cite: 28]
    public Pago Pago { get; set; }
    public string Tipo { get; set; } // Boleta o Factura [cite: 29]
    public string Serie { get; set; } // [cite: 29]
    public string NumeroCorrelativo { get; set; } // [cite: 29]
}