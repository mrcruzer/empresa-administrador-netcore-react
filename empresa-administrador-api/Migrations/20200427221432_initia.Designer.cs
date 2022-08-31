﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using empresa_administrador_api.Models;

namespace empresa_administrador_api.Migrations
{
    [DbContext(typeof(EmpresaDbContext))]
    [Migration("20200427221432_initia")]
    partial class initia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("empresa_administrador_api.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Direccion")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("Nomina")
                        .HasColumnType("int");

                    b.Property<string>("Posicion")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("TipoNomina")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
