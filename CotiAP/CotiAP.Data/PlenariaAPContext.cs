using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using CotiAP.Entities;

namespace CotiAP.Data
{
    public partial class PlenariaAPContext : DbContext
    {
        public PlenariaAPContext()
            : base("name=PlenariaAPConnection")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Condicion> Condicion { get; set; }
        public virtual DbSet<DerechoEmision> DerechoEmision { get; set; }
        public virtual DbSet<Descuento> Descuento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.numeroCategoria)
                .IsUnicode(false);

            modelBuilder.Entity<Condicion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DerechoEmision>()
                .Property(e => e.nombreDerechoEmision)
                .IsUnicode(false);

            modelBuilder.Entity<Descuento>()
                .Property(e => e.nombreDescuento)
                .IsUnicode(false);
        }
    }
}
