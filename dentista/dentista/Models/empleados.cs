using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentista.Models
{
    class empleado
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int      id_empleado { get; set; }
        [StringLength(100)]
        public string   nombre      { get; set; }
        [StringLength(100)]
        public string   apellidos   { get; set; }
        [StringLength(100)]
        public string   usuario     { get; set; }
        [StringLength(100)]
        public string      password    { get; set; }
        [StringLength(100)]
        public string   correo { get; set; }
        [StringLength(100)]
        public string   cargo { get; set; }
        [StringLength(18)]
        public string   telefono { get; set; }
        public int      estado      { get; set; }
    }
}
