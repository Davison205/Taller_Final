using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Taller_Final.Models.Entities;

namespace Taller_Final.ViewModels
{
    public class EmpleadoViewModel
    {
 
        public int EmpleadoId { get; set; }

        public string Nombre { get; set; }
        public int Documento { get; set; }
        public string Telefono { get; set; }

        public string NombreImagen { get; set; }

        public virtual List<EmpleadoDetalle> EmpleadoDetalles { get; set; }
    }
}
