using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Enfermeros")]
    public class Enfermero: Persona
    {
        public int Cuil { get; set; }
        public List<Paciente> Pacientes { get; set;}
    }
}
