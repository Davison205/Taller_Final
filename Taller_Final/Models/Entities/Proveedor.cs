using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Final.Models.Entities
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El identificacion es obligatorio")]
        public int Identicacion { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public String Nombre { get; set; }

        public String PersonaContacto { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
    }
}
