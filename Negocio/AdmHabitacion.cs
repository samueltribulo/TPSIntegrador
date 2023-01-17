using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();

            listaHabitacion.Add(new Habitacion() { ID = 1, Numero = 1, Estado = "Ocupado" });
            listaHabitacion.Add(new Habitacion() { ID = 2, Numero = 2, Estado = "Libre" });
            listaHabitacion.Add(new Habitacion() { ID = 3, Numero = 3, Estado = "Libre" });
            listaHabitacion.Add(new Habitacion() { ID = 4, Numero = 4, Estado = "Ocupado" });
            listaHabitacion.Add(new Habitacion() { ID = 5, Numero = 5, Estado = "Libre" });

            return listaHabitacion;
        }

        public static List<Habitacion> Listar(int Estado)
        {
            //TODO…Seleccionar codigo para listar por Estado
            return null;
        }
        public static int Insertar(Habitacion habitacion)
        {
            //TODO…Implementar código para insertar en la tabla
            return 0;
        }

        public static int Eliminar(int ID)
        {
            //TODO…Implementar código para eliminar
            return 0;
        }

        public static Habitacion TraerUno(int nroHabitacion)
        {
            //TODO…Falta implementar código para hacer un select de Habitacion
            return null;
        }
    }
}