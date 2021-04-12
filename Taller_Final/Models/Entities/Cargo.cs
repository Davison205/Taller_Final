using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Final.Models.Entities
{
    public class Cargo
    {
        [Key]
        public int CargoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public virtual List<EmpleadoDetalle> EmpleadoDetalles { get; set; }
    }
}
