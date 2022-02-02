﻿// <auto-generated />
using System;
using MatrixCRUDTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MatrixCRUDTech.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MatrixCRUDTech.Models.IndicadorPrograma", b =>
                {
                    b.Property<int>("IdIndicador")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("IndiceApuracao")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("IndiceDesejado")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("ProgramaID");

                    b.Property<string>("UndMedida")
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdIndicador");

                    b.HasIndex("ProgramaID")
                        .IsUnique();

                    b.ToTable("IndicadorProgramas");
                });

            modelBuilder.Entity("MatrixCRUDTech.Models.ObjetivoPrograma", b =>
                {
                    b.Property<int>("IdObjetivo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(150)");

                    b.Property<int>("ProgramaId");

                    b.HasKey("IdObjetivo");

                    b.HasIndex("ProgramaId");

                    b.ToTable("ObjetivoProgramas");
                });

            modelBuilder.Entity("MatrixCRUDTech.Models.Programa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(70)");

                    b.Property<int>("ObjMilenio");

                    b.Property<string>("PublicoAlvo")
                        .HasColumnType("varchar(70)");

                    b.Property<int>("Tipo");

                    b.HasKey("Codigo");

                    b.ToTable("Programa");
                });

            modelBuilder.Entity("MatrixCRUDTech.Models.IndicadorPrograma", b =>
                {
                    b.HasOne("MatrixCRUDTech.Models.Programa", "ObjPrograma")
                        .WithOne("ObjIndicadorPrograma")
                        .HasForeignKey("MatrixCRUDTech.Models.IndicadorPrograma", "ProgramaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MatrixCRUDTech.Models.ObjetivoPrograma", b =>
                {
                    b.HasOne("MatrixCRUDTech.Models.Programa", "Programa")
                        .WithMany("ObjetivoProgramas")
                        .HasForeignKey("ProgramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
