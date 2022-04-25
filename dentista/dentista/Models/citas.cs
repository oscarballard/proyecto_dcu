using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentista.Models
{
    class citas
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int    id_cita { get; set; }
        public string id_paciente { get; set; }
        public string id_doctor { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_cita { get; set; }
        public int estado { get; set; }
    }
}
