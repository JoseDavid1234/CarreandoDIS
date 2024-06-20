using CarreandoDIS.Models;
using Microsoft.EntityFrameworkCore;

namespace CarreandoDIS
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Plan> Plan { get; set; }

        public DbSet<Promocion> Promocion { get; set; }

        public DbSet<Recibo> Recibo { get; set; }

        public DbSet<Reclamacion> Reclamacion { get; set; }

        public DbSet<Resenia> Resenia { get; set; }

        public DbSet<Servicio> Servicio { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Host=dpg-covel5i1hbls73dp5mbg-a.oregon-postgres.render.com;Database=tel_db_dkoz;Username=josue;Password=c2vwLAjiOBGxPNjbMY7WYdjDTggTRJBS;Port=5432";

            optionsBuilder.UseNpgsql(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

    }
}
