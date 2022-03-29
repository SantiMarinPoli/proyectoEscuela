using System;
using System.ComponentModel.DataAnnotations;

namespace escuelaWeb.Models
{
    public abstract class ObjetoEscuelaBase
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}