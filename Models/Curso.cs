using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace escuelaWeb.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del curso es requerido.")]
        [StringLength(5)]
        public override string Nombre {get;set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        [Display(Prompt ="Direccion Correspondencia.",Name ="Address")]
        [Required(ErrorMessage = "Se requiere incluir una direccion.")]
        [MinLength(10, ErrorMessage = "La longuitud requerida de la direccion es 10.")]
        public string Dirección { get; set; }

        public string EscuelaId {get;set;}

        public Escuela Escuela {get;set;}

    }
}