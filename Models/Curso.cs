using System;
using System.Collections.Generic;

namespace platzi_curso_aspcore.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Course> Course{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }

    }
}