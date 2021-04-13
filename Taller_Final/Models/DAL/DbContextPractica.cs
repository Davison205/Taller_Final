using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller_Final.Models.Entities;

namespace Taller_Final.Models.DAL
{
    public class DbContextPractica : DbContext
    {
        public DbContextPractica(DbContextOptions<DbContextPractica> options) :
           base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<EmpleadoDetalle> EmpleadoDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveerdores { get; set; }
    }
}
