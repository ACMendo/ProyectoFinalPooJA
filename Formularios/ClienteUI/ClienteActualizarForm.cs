using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPooJA.Formularios.ClienteUI
{
    public partial class ClienteActualizarForm : Form
    {
        public ClienteActualizarForm()
        {
            InitializeComponent();
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtIdentificacion.Clear();
            txtDireccion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
