namespace DKaiza.Web.Models;

public class Servicio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int DuracionMinutos { get; set; }
    public bool Activo { get; set; } = true; // Para borrado lógico (HU_09)

    public int CategoriaId { get; set; }
    public CategoriaServicio Categoria { get; set; }
    public ICollection<Cita> Citas { get; set; } = new List<Cita>();
}