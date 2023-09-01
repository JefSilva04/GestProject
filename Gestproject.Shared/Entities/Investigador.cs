using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestproject.Shared.Entities
{
    public class Investigador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string Nombre { get; set; } = null;

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string Especializacion { get; set; } = null;

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string RolProyecto { get; set; } = null;

        public string Afiliacion { get; set; } = null;

    }
}