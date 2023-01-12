using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public static class DacMedico
    {
        public static List<Medico> Select()
        {
            //TODO: Seleccionar todos los Medicos
            return null;
        }
        public static List<Medico> Select(string Especialidad)
        {
            //TODO: Falta implementar codigo para hacer un select por especialidad
            return null;
        }
        public static int Insert(Medico medico)
        {
            //TODO: Falta implementar codigo para hacer un insert en la tabla Alumno
            return 0;
        }

        public static Medico SelectById(int id)
        {
            //TODO: Falta implementar codigo para hacer un selectby id en la tabla medicos
            return null;
        }
        public static int Eliminar(int id)
        {
            //TODO: Falta implementar codigo pata hacer un Delete en la tabla medico por el id
            return 0;
        }
    }
}
