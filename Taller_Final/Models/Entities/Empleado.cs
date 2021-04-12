using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Final.Models.Entities
{
public class Empleado
{

        [Key]
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [Column("NombreEmpleado", TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }
        public int Documento { get; set; }

        [DisplayName("Cargo empleado")]
        public string Telefono { get; set; }

        public string NombreImagen { get; set; }

        public virtual List<EmpleadoDetalle> EmpleadoDetalles { get; set; }
    }
}
