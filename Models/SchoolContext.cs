using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace platzi_curso_aspcore.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Escuela> Escuelas {get;set;}
        public DbSet<Asignatura> Asignaturas {get;set;}
        public DbSet<Alumno> Students {get;set;}
        public DbSet<Curso> Cursos {get;set;}
        public DbSet<Evaluación> Evaluations {get;set;}

        public SchoolContext (DbContextOptions<SchoolContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var school = new Escuela();
            school.yearFoundation = 2010;
            school.EscuelaId = Guid.NewGuid().ToString();
            school.name = "Platzi School";
            school.City = "Bogota";
            school.Country = "Colombia";
            school.TipoEscuela = TiposEscuela.Secundaria;
            school.Direction = "Av. Siempre Viva";

            //Cargar Cursos de la escuela
            var cursos = CargarCursos(school);
            //x cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);
            //x cada curso cargar alumnos
            var alumnos = CargarAlumno(cursos);

            builder.Entity<Escuela>().HasData(school);
            builder.Entity<Curso>().HasData(cursos.ToArray());
            builder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            builder.Entity<Alumno>().HasData(alumnos.ToArray());


        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
            new Curso(){
                UniqueId = Guid.NewGuid().ToString(),
                EscuelaId = escuela.UniqueId,
                Nombre = "101",
                Jornada = TiposJornada.Mañana
            },                      
             new Curso(){
                UniqueId = Guid.NewGuid().ToString(),
                EscuelaId = escuela.UniqueId,
                Nombre = "102",
                Jornada = TiposJornada.Noche
            },
                         new Curso(){
                UniqueId = Guid.NewGuid().ToString(),
                EscuelaId = escuela.UniqueId,
                Nombre = "103",
                Jornada = TiposJornada.Tarde
            }};
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            List<Asignatura> listaAsignatura = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                listaAsignatura = new List<Asignatura>();
                var tmpAsig =  new List<Asignatura> {
                                new Asignatura{Nombre = "Programming",
                                    UniqueId = Guid.NewGuid().ToString(),
                                    CursoId = curso.UniqueId
                                },
                                new Asignatura{Nombre = "Math",
                                    UniqueId = Guid.NewGuid().ToString(),
                                    CursoId = curso.UniqueId
                                },
                                new Asignatura{Nombre = "Sciences",
                                    UniqueId = Guid.NewGuid().ToString(),
                                    CursoId = curso.UniqueId
                                }, 
                                new Asignatura{Nombre = "Artistic",
                                 UniqueId = Guid.NewGuid().ToString(),
                                 CursoId = curso.UniqueId
                                }
                            };
                curso.Asignaturas = tmpAsig;
                listaAsignatura.AddRange(tmpAsig);
                
            }
            return listaAsignatura;
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cant,Curso curso)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   CurosId = curso.UniqueId,
                                   Nombre = $"{n1} {n2} {a1}",
                                   UniqueId = Guid.NewGuid().ToString()
                                };

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cant).ToList();
        }

        private List<Alumno> CargarAlumno(List<Curso> cursos)
        {
            var listaAlum = new List<Alumno>();

            Random rdm = new Random();
            foreach (var curso in cursos)
            {
                int cantRnd = rdm.Next(5,20);
                var tmpList = GenerarAlumnosAlAzar(cantRnd,curso);
                listaAlum.AddRange(tmpList);  
            }
            return listaAlum;
        }

    }
}