using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    public partial class IncidenciaCrearForm : Form
    {
        public IncidenciaCrearForm()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
            cbxTaller.SelectedIndex = 0;
            cbxVehiculo.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
