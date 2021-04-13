using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Final.Models.Entities
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Column("nombre", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El existencia es obligatorio")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El fecha ingreso es obligatorio")]
        public double FechaIngreso { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio")]
        public int ProveedorId { get; set; }
    }
}
