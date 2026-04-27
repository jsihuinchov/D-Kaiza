using Microsoft.AspNetCore.Identity;

namespace DKaiza.Web.Models;

public class ApplicationUser : IdentityUser
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    // Relaciones
    public ICollection<Cliente> ClientesRegistrados { get; set; } = new List<Cliente>();
    public ICollection<Estilista> EstilistasRegistrados { get; set; } = new List<Estilista>();
}