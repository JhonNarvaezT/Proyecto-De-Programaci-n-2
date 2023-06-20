using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class ActaNotasContext : DbContext
    {
        public ActaNotasContext(DbContextOptions<ActaNotasContext> options) : base(options)
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Calificacion> Calificacions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>().HasData(
                new Grupo()
                {
                    GrupoId = 1,
                    Nombre = "1M1-IS",
                    Año = "1"
                },
                new Grupo()
                {
                    GrupoId = 2,
                    Nombre = "1M1-IS",
                    Año = "1"
                });
            modelBuilder.Entity<Estudiante>().HasData(
                new Estudiante()
                {
                    EstudianteId = 1,
                    Nombre = "Carlos Morales",
                    GrupoId = 2,
                    Carnet = "2023-0101U"
                },
                new Estudiante()
                {
                    EstudianteId = 2,
                    Nombre = "Maria Lopez",
                    GrupoId = 2,
                    Carnet = "2023-0102U"
                },
                new Estudiante()
                {
                    EstudianteId = 3,
                    Nombre = "John Reyes",
                    GrupoId = 1,
                     Carnet = "2023-0103U"
                });
            modelBuilder.Entity<Asignatura>().HasData(
               new Asignatura()
               {
                   AsignaturaId = 1,
                   AsignaturaNombre = "Introduccion a la Programacion",
                   Semestre = "Primer Semestre",
                   Creditos = 4
               },
               new Asignatura()
               {
                   AsignaturaId = 2,
                   AsignaturaNombre = "Calculo 1",
                   Semestre = "Primer Semestre",
                   Creditos = 4
               });
            modelBuilder.Entity<Calificacion>().HasData(
              new Calificacion()
              {
                  CalificacionId = 1,
                  EstudianteId= 1,
                  AsignaturaId = 1,
                  nota = 100
              },
              new Calificacion()
              {
                  CalificacionId = 2,
                  EstudianteId = 1,
                  AsignaturaId = 1,
                  nota = 100
              },
              new Calificacion()
              {
                  CalificacionId = 3,
                  EstudianteId = 1,
                  AsignaturaId = 1,
                  nota = 80
              },
              //
               new Calificacion()
               {
                   CalificacionId = 4,
                   EstudianteId = 1,
                   AsignaturaId = 2,
                   nota = 90
               },
              new Calificacion()
              {
                  CalificacionId = 5,
                  EstudianteId = 1,
                  AsignaturaId = 2,
                  nota = 100
              },
              new Calificacion()
              {
                  CalificacionId = 6,
                  EstudianteId = 1,
                  AsignaturaId = 2,
                  nota = 60
              },
              //
                 new Calificacion()
                 {
                     CalificacionId = 7,
                     EstudianteId = 2,
                     AsignaturaId = 1,
                     nota = 90
                 },
              new Calificacion()
              {
                  CalificacionId = 8,
                  EstudianteId = 2,
                  AsignaturaId = 1,
                  nota = 70
              },
              new Calificacion()
              {
                  CalificacionId = 9,
                  EstudianteId = 2,
                  AsignaturaId = 1,
                  nota = 100
              },
              //
                 new Calificacion()
                 {
                     CalificacionId = 10,
                     EstudianteId = 2,
                     AsignaturaId = 1,
                     nota = 90
                 },
              new Calificacion()
              {
                  CalificacionId = 11,
                  EstudianteId = 2,
                  AsignaturaId = 2,
                  nota = 70
              },
              new Calificacion()
              {
                  CalificacionId = 12,
                  EstudianteId = 2,
                  AsignaturaId = 2,
                  nota = 100
              },
              //
              new Calificacion()
              {
                  CalificacionId = 13,
                  EstudianteId = 3,
                  AsignaturaId = 1,
                  nota = 75
              },
              new Calificacion()
              {
                  CalificacionId = 14,
                  EstudianteId = 3,
                  AsignaturaId = 1,
                  nota = 90
              },
              new Calificacion()
              {
                  CalificacionId = 15,
                  EstudianteId = 3,
                  AsignaturaId = 1,
                  nota = 100
              },
              //
              new Calificacion()
              {
                  CalificacionId = 16,
                  EstudianteId = 3,
                  AsignaturaId = 2,
                  nota = 90
              },
              new Calificacion()
              {
                  CalificacionId = 17,
                  EstudianteId = 3,
                  AsignaturaId = 2,
                  nota = 70
              },
              new Calificacion()
              {
                  CalificacionId = 18,
                  EstudianteId = 3,
                  AsignaturaId = 2,
                  nota = 100
              });
        }


    }
}
