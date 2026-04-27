// Models/CategoriaServicio.cs
namespace DKaiza.Web.Models;

public class CategoriaServicio 
{
    public int Id { get; set; } // [cite: 9]
    public string Nombre { get; set; } // Ej: Barbería, Manicura [cite: 9]
    
    // Esto permite ver todos los servicios de una categoría
    public ICollection<Servicio> Servicios { get; set; } 
}