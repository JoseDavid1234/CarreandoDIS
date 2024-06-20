﻿using CarreandoDIS.Models;
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

    }
}
