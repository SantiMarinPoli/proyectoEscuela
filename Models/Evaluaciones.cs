using System;

namespace platzi_curso_aspcore.Models
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Curso Asignatura  { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}