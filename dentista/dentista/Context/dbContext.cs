using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using dentista.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dentista.Context
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Server=DESKTOP-MKEO61A;Database=h;Trusted_Connection=True;")
        {

        }
        public  DbSet<citas>     dtocitas { get; set; }
        public  DbSet<Pacientes> dtoPacientes { get; set; }
        public  DbSet<empleado> dtoEmpleados { get; set; }
        public  DbSet<consulta>  dtoconsulta { get; set; }
    }
}
