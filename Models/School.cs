using System.Collections.Generic;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Models
{
    public class School:ObjetoEscuelaBase
    {
        public string schoolId {get;set;}
        public string name {get;set;}
        public int yearFoundation {get;set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Dirección { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public School(string nombre, int año) => (Nombre, yearFoundation) = (nombre, año);

        public School()
        {}

        public School(string nombre, int año, 
                       TiposEscuela tipo, 
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, yearFoundation) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}