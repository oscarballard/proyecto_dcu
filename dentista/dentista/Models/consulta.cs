using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentista.Models
{
    class consulta
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id_consulta { get; set; }
        public int id_paciente { get; set; }
        public int id_doctor { get; set; }
        [StringLength(100)]
        public string motivo { get; set; }
        public int id_cita { get; set; }
        [StringLength(300)]
        public string detalle_consulta { get; set; }

    }
}
