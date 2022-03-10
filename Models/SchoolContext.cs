using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace platzi_curso_aspcore.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<School> Schools {get;set;}
        public DbSet<Asignatura> Asignaturas {get;set;}
        public DbSet<Alumno> Students {get;set;}
        public DbSet<Curso> Cursos {get;set;}
        public DbSet<Evaluación> Evaluations {get;set;}

        public SchoolContext (DbContextOptions<SchoolContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var school = new School();
            school.yearFoundation = 2010;
            school.schoolId = Guid.NewGuid().ToString();
            school.name = "Platzi School";
            school.City = "Bogota";
            school.Country = "Colombia";
            school.TipoEscuela = TiposEscuela.Secundaria;
            school.Direction = "Av. Siempre Viva";

            builder.Entity<School>().HasData(school);

            builder.Entity<Asignatura>().HasData(
                                new Asignatura{Nombre = "Programming",
                                    UniqueId = Guid.NewGuid().ToString()
                                },
                                new Asignatura{Nombre = "Math",
                                    UniqueId = Guid.NewGuid().ToString()
                                },
                                new Asignatura{Nombre = "Sciences",
                                    UniqueId = Guid.NewGuid().ToString()
                                }, 
                                new Asignatura{Nombre = "Artistic",
                                 UniqueId = Guid.NewGuid().ToString()
                                }
                            );
            builder.Entity<Alumno>()
                    .HasData(GenerarAlumnosAlAzar().ToArray());
            
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }

    }
}