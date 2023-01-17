using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {

            List<Paciente> listaPacientes = new List<Paciente>();


            listaPacientes.Add(new Paciente() { ID = 1, Nombre = "Juana", Apellido = "Perez", Domicilio = "CABA", Email = "juana@gmail.com", NroHistoriaClinica = 001, Telefono = 1134345656 });
            listaPacientes.Add(new Paciente() { ID = 2, Nombre = "Matias", Apellido = "Gonzalez", Domicilio = "Rosario", Email = "mati@gmail.com", NroHistoriaClinica = 002, Telefono = 1156567878 });
            listaPacientes.Add(new Paciente() { ID = 3, Nombre = "Ana", Apellido = "Perez", Domicilio = "CABA", Email = "ana@hotmail.com", NroHistoriaClinica = 003, Telefono = 1178789966 });
            listaPacientes.Add(new Paciente() { ID = 4, Nombre = "Lucia", Apellido = "Ramirez", Domicilio = "Cordoba", Email = "luci@gmail.com", NroHistoriaClinica = 004, Telefono = 1123557878 });
            listaPacientes.Add(new Paciente() { ID = 5, Nombre = "Pablo", Apellido = "Fernadez", Domicilio = "Entre Rios", Email = "pablito@gmail.com", NroHistoriaClinica = 005, Telefono = 1145897676 });

            return listaPacientes;
        }
        public static int Insertar(Paciente paciente)
        {
            //TODO: metodo para insertar los pacientes
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO: metodo para eliminar los pacientes
            return 0;
        }
        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO: metodo para listar un paciente por su numero de historia Clinica
            return null;
        }

    }
}
