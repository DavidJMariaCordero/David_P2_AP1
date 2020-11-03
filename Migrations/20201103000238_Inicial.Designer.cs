﻿// <auto-generated />
using System;
using David_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace David_P2_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201103000238_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("David_P2_AP1.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("David_P2_AP1.Entidades.ProyectosDetalle", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimientos")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDetalle");

                    b.HasIndex("ProyectoId");

                    b.ToTable("ProyectosDetalle");
                });

            modelBuilder.Entity("David_P2_AP1.Entidades.TipoTareas", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoId");

                    b.ToTable("TipoTareas");

                    b.HasData(
                        new
                        {
                            TipoId = 1,
                            Descripcion = "Analisis"
                        },
                        new
                        {
                            TipoId = 2,
                            Descripcion = "Diseño"
                        },
                        new
                        {
                            TipoId = 3,
                            Descripcion = "Programacion"
                        },
                        new
                        {
                            TipoId = 4,
                            Descripcion = "Prueba"
                        });
                });

            modelBuilder.Entity("David_P2_AP1.Entidades.ProyectosDetalle", b =>
                {
                    b.HasOne("David_P2_AP1.Entidades.Proyectos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
