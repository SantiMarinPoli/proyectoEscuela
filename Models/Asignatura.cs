using System;

namespace platzi_curso_aspcore.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId {get;set;}
        public Curso Curso {get;set;}
        public List<Evaluación> Evaluaciones {get;set;}
    }
}