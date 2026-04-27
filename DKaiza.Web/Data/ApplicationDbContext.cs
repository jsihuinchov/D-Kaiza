using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DKaiza.Web.Models;

namespace DKaiza.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Módulo de Clientes (E003)
    public DbSet<Cliente> Clientes { get; set; }

    // Módulo de Estilistas y Agenda (E005)
    public DbSet<Estilista> Estilistas { get; set; }
    public DbSet<HorarioLaboral> Horarios { get; set; }

    // Módulo de Servicios y Catálogo (E002)
    public DbSet<Servicio> Servicios { get; set; } // [cite: 10]
    public DbSet<CategoriaServicio> CategoriaServicios { get; set; } // [cite: 9]

    // Módulo de Reservas (E001)
    public DbSet<Cita> Citas { get; set; }

    // Módulo de Facturación y Pagos (E004)
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Comprobante> Comprobantes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurar relaciones y restricciones
        
        // Relación Cita -> Cliente (1:N)
        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Cliente)
            .WithMany(cl => cl.Citas)
            .HasForeignKey(c => c.ClienteId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación Cita -> Estilista (1:N)
        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Estilista)
            .WithMany(e => e.Citas)
            .HasForeignKey(c => c.EstilistaId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación Cita -> Servicio (1:N)
        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Servicio)
            .WithMany(s => s.Citas)
            .HasForeignKey(c => c.ServicioId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación Pago -> Cita (1:N)
        modelBuilder.Entity<Pago>()
            .HasOne(p => p.Cita)
            .WithMany(c => c.Pagos)
            .HasForeignKey(p => p.CitaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relación Comprobante -> Pago (1:N)
        modelBuilder.Entity<Comprobante>()
            .HasOne(co => co.Pago)
            .WithMany(p => p.Comprobantes)
            .HasForeignKey(co => co.PagoId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relación HorarioLaboral -> Estilista (1:N)
        modelBuilder.Entity<HorarioLaboral>()
            .HasOne(h => h.Estilista)
            .WithMany(e => e.Horarios)
            .HasForeignKey(h => h.EstilistaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relación Servicio -> CategoriaServicio (1:N)
        modelBuilder.Entity<Servicio>()
            .HasOne(s => s.Categoria)
            .WithMany(cs => cs.Servicios)
            .HasForeignKey(s => s.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}