using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public partial class EntregaActualizarForm : Form
    {
        public EntregaActualizarForm()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Clear();
            txtDescripcion.Clear();
            txtPeso.Clear();
            cbxCliente.SelectedIndex = 0;
            cbxEmpleado.SelectedIndex = 0;
            cbxPrioridad.SelectedIndex = 0;
            dtpFechaRegreso.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
