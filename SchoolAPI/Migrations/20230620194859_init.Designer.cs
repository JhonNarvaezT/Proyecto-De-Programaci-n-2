﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolAPI.Data;

#nullable disable

namespace ActaNotasAPI.Migrations
{
    [DbContext(typeof(ActaNotasContext))]
    [Migration("20230620194859_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolAPI.Models.Asignatura", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AsignaturaId"));

                    b.Property<string>("AsignaturaNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<string>("Semestre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignaturas");

                    b.HasData(
                        new
                        {
                            AsignaturaId = 1,
                            AsignaturaNombre = "Introduccion a la Programacion",
                            Creditos = 4,
                            Semestre = "Primer Semestre"
                        },
                        new
                        {
                            AsignaturaId = 2,
                            AsignaturaNombre = "Calculo 1",
                            Creditos = 4,
                            Semestre = "Primer Semestre"
                        });
                });

            modelBuilder.Entity("SchoolAPI.Models.Calificacion", b =>
                {
                    b.Property<int>("CalificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalificacionId"));

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<float>("nota")
                        .HasColumnType("real");

                    b.HasKey("CalificacionId");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Calificacions");

                    b.HasData(
                        new
                        {
                            CalificacionId = 1,
                            AsignaturaId = 1,
                            EstudianteId = 1,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 2,
                            AsignaturaId = 1,
                            EstudianteId = 1,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 3,
                            AsignaturaId = 1,
                            EstudianteId = 1,
                            nota = 80f
                        },
                        new
                        {
                            CalificacionId = 4,
                            AsignaturaId = 2,
                            EstudianteId = 1,
                            nota = 90f
                        },
                        new
                        {
                            CalificacionId = 5,
                            AsignaturaId = 2,
                            EstudianteId = 1,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 6,
                            AsignaturaId = 2,
                            EstudianteId = 1,
                            nota = 60f
                        },
                        new
                        {
                            CalificacionId = 7,
                            AsignaturaId = 1,
                            EstudianteId = 2,
                            nota = 90f
                        },
                        new
                        {
                            CalificacionId = 8,
                            AsignaturaId = 1,
                            EstudianteId = 2,
                            nota = 70f
                        },
                        new
                        {
                            CalificacionId = 9,
                            AsignaturaId = 1,
                            EstudianteId = 2,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 10,
                            AsignaturaId = 1,
                            EstudianteId = 2,
                            nota = 90f
                        },
                        new
                        {
                            CalificacionId = 11,
                            AsignaturaId = 2,
                            EstudianteId = 2,
                            nota = 70f
                        },
                        new
                        {
                            CalificacionId = 12,
                            AsignaturaId = 2,
                            EstudianteId = 2,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 13,
                            AsignaturaId = 1,
                            EstudianteId = 3,
                            nota = 75f
                        },
                        new
                        {
                            CalificacionId = 14,
                            AsignaturaId = 1,
                            EstudianteId = 3,
                            nota = 90f
                        },
                        new
                        {
                            CalificacionId = 15,
                            AsignaturaId = 1,
                            EstudianteId = 3,
                            nota = 100f
                        },
                        new
                        {
                            CalificacionId = 16,
                            AsignaturaId = 2,
                            EstudianteId = 3,
                            nota = 90f
                        },
                        new
                        {
                            CalificacionId = 17,
                            AsignaturaId = 2,
                            EstudianteId = 3,
                            nota = 70f
                        },
                        new
                        {
                            CalificacionId = 18,
                            AsignaturaId = 2,
                            EstudianteId = 3,
                            nota = 100f
                        });
                });

            modelBuilder.Entity("SchoolAPI.Models.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudianteId"));

                    b.Property<string>("Carnet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new
                        {
                            EstudianteId = 1,
                            Carnet = "2023-0101U",
                            GrupoId = 2,
                            Nombre = "Carlos Morales"
                        },
                        new
                        {
                            EstudianteId = 2,
                            Carnet = "2023-0102U",
                            GrupoId = 2,
                            Nombre = "Maria Lopez"
                        },
                        new
                        {
                            EstudianteId = 3,
                            Carnet = "2023-0103U",
                            GrupoId = 1,
                            Nombre = "John Reyes"
                        });
                });

            modelBuilder.Entity("SchoolAPI.Models.Grupo", b =>
                {
                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Año")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GrupoId");

                    b.ToTable("Grupos");

                    b.HasData(
                        new
                        {
                            GrupoId = 1,
                            Año = "1",
                            Nombre = "1M1-IS"
                        },
                        new
                        {
                            GrupoId = 2,
                            Año = "1",
                            Nombre = "1M1-IS"
                        });
                });

            modelBuilder.Entity("SchoolAPI.Models.Calificacion", b =>
                {
                    b.HasOne("SchoolAPI.Models.Asignatura", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolAPI.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("SchoolAPI.Models.Estudiante", b =>
                {
                    b.HasOne("SchoolAPI.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });
#pragma warning restore 612, 618
        }
    }
}
