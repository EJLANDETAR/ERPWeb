﻿// <auto-generated />
using System;
using ERPWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERPWebApi.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20190824223006_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ERPWebApi.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("DNI")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Direccion")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("Varchar(50)");

                    b.Property<int>("Estatus");

                    b.Property<DateTime>("FechaCreado");

                    b.Property<DateTime?>("FechaDeleted");

                    b.Property<DateTime?>("FechaModificado");

                    b.Property<string>("Logo")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("ModificadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Nombre")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Telefono1")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Telefono2")
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("ERPWebApi.Models.Entidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("DNI")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Direccion")
                        .HasColumnType("Varchar(200)");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("Varchar(60)");

                    b.Property<int>("EmpresaId");

                    b.Property<DateTime>("FechaCreado");

                    b.Property<DateTime?>("FechaDeleted");

                    b.Property<DateTime?>("FechaModificado");

                    b.Property<string>("ModificadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Nombres")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Picture")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("Telefono1")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Telefono2")
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Entidad");
                });

            modelBuilder.Entity("ERPWebApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("CreadoPor")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<int>("EmpresaId");

                    b.Property<int?>("EntidadId");

                    b.Property<int>("Estatus");

                    b.Property<DateTime>("FechaCreado");

                    b.Property<DateTime?>("FechaDeleted");

                    b.Property<DateTime?>("FechaModificado");

                    b.Property<string>("ModificadoPor")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Picture")
                        .HasColumnType("Varchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EntidadId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ERPWebApi.Models.Entidad", b =>
                {
                    b.HasOne("ERPWebApi.Models.Empresa", "Empresa")
                        .WithMany("Entidades")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERPWebApi.Models.Usuario", b =>
                {
                    b.HasOne("ERPWebApi.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ERPWebApi.Models.Entidad")
                        .WithMany("Usuarios")
                        .HasForeignKey("EntidadId");
                });
#pragma warning restore 612, 618
        }
    }
}
