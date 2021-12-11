﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Veterinaria3._0_1._0.Models;

namespace Veterinaria3._0_1._0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211204052202_PrimeaMigracion")]
    partial class PrimeaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Veterinaria3._0_1._0.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FechaCita")
                        .HasColumnType("text");

                    b.Property<string>("HoraCita")
                        .HasColumnType("text");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("text");

                    b.Property<string>("NombreVeterinario")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Veterinaria3._0_1._0.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.Property<int>("Telefono")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Veterinaria3._0_1._0.Models.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ProductoCantidadPrecio")
                        .HasColumnType("text");

                    b.Property<int>("Total")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("Veterinaria3._0_1._0.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ColorPelo")
                        .HasColumnType("text");

                    b.Property<string>("Especie")
                        .HasColumnType("text");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("text");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Veterinaria3._0_1._0.Models.Mercancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<double>("Precio")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Mercancia");
                });
#pragma warning restore 612, 618
        }
    }
}