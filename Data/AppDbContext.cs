using ClínicaVeterinária.Models;
using Microsoft.EntityFrameworkCore;

namespace ClínicaVeterinária.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
            public DbSet<Consulta> Consultas { get; set; }
            public DbSet<Pet> Pets { get; set; }
            public DbSet<Tutor> Tutores { get; set; }
            public DbSet<Veterinario> Veterinarios { get; set; }
    }

    }

