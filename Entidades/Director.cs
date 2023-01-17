using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table(("Directores"))]
    public class Director:Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string PostGrado { get; set; }


    }
}
