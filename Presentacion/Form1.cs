using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
            gridMedicos.DataSource = AdmMedico.Listar();
        }

        private void listHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Habitacion> listaHabitaciones = AdmHabitacion.Listar();

            foreach (Habitacion habitacion in listaHabitaciones) 
            {
                listHabitaciones.Items.Add($"Habitaciones: {habitacion.Numero.ToString()},{habitacion.Estado} ");
            }
        }
    }
}