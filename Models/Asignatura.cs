using System;

namespace escuelaWeb.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId {get;set;}
        public Curso Curso {get;set;}

    }
}