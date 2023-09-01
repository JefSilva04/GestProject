using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestproject.Shared.Entities
{
    internal class Projects
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string NombreProjecto { get; set; } = null;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string LiderProyecto { get; set; } = null;

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string Descripcion { get; set; } = null;

        [Required(ErrorMessage = "Este campo obligatorio")]
        public string AreaInvestigacion { get; set; } = null;

        public List<Investigador> Investigadores
        {
            get; set;
        }
    }
}