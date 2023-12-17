using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetVet.Models;

namespace PetVet.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet para cada entidad en tu modelo
    public DbSet<Doctor> Doctores { get; set; }
    public DbSet<Veterinaria> Veterinarias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Tratamiento> Tratamientos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().ToTable("Doctor");
        modelBuilder.Entity<Veterinaria>().ToTable("Veterinaria");
        modelBuilder.Entity<Usuario>().ToTable("Usuario");
        modelBuilder.Entity<Mascota>().ToTable("Mascota");
        modelBuilder.Entity<Tratamiento>().ToTable("Tratamiento");
        base.OnModelCreating(modelBuilder);
    }
}

