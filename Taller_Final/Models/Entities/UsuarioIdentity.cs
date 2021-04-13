using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Final.Models.Entities
{
    public class UsuarioIdentity:IdentityUser
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(20, ErrorMessage = "el {0} debe tener al menos {2} y maximo {1} caracteres.", MinimumLength = 8)]
        public string Nombre { get; set; }
        public long Documento { get; set; }
    }
}
