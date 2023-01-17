using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Pacientes")]
    public class Paciente:Persona
    {
        public int NroHistoriaClinica { get; set; }
        public Enfermero Enfermero { get; set; }
        public Medico Medico { get; set; }
        public Habitacion Habitacion { get; set; }

    }
}
