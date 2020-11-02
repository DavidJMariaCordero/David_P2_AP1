using David_P2_AP1.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace David_P2_AP1.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source = Data/Parcial.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoTareas>().HasData(new TipoTareas() { TipoId = 1, Descripcion = "Analisis"});
            modelBuilder.Entity<TipoTareas>().HasData(new TipoTareas() { TipoId = 2, Descripcion = "Diseño" });
            modelBuilder.Entity<TipoTareas>().HasData(new TipoTareas() { TipoId = 3, Descripcion = "Programacion" });
            modelBuilder.Entity<TipoTareas>().HasData(new TipoTareas() { TipoId = 4, Descripcion = "Prueba" });
        }
        
    }
}
