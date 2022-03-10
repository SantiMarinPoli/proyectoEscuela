using System;
using System.Collections.Generic;

namespace platzi_curso_aspcore.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public string CurosId {get;set;}
        public Curso Curso {get;set;}
        public List<Evaluación> Evaluaciones { get; set; }
    }
}