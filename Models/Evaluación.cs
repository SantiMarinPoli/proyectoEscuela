using System;

namespace platzi_curso_aspcore.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public Course Course  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Course}";
        }
    }
}