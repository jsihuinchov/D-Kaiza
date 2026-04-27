// Models/Servicio.cs
public class Servicio {
    public int Id { get; set; } [cite: 10]
    public string Nombre { get; set; } [cite: 10]
    public string Descripcion { get; set; } [cite: 10]
    public decimal Precio { get; set; } [cite: 10]
    public int DuracionMinutos { get; set; } [cite: 10]
    public bool Activo { get; set; } = true; [cite: 12]
    
    public int CategoriaId { get; set; } [cite: 11]
    public CategoriaServicio Categoria { get; set; }
}

// Models/Estilista.cs
public class Estilista {
    public int Id { get; set; } [cite: 14]
    public string UsuarioId { get; set; } // FK a Identity [cite: 14]
    public string Especialidad { get; set; } [cite: 15]
    public string FotoUrl { get; set; } [cite: 15]
    public List<HorarioLaboral> Horarios { get; set; } [cite: 16]
}