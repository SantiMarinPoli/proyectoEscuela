using System.Collections.Generic;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Models
{
    public class Escuela:ObjetoEscuelaBase
    {
        public string EscuelaId {get;set;}
        public string name {get;set;}
        public int yearFoundation {get;set;}
        public string Country { get; set; }
        public string City { get; set; }

        public string Direction { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, yearFoundation) = (nombre, año);

        public Escuela()
        {}

        public Escuela(string nombre, int año, 
                       TiposEscuela tipo, 
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, yearFoundation) = (nombre, año);
            Country = pais;
            City = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Country}, Ciudad:{City}";
        }
    }
}