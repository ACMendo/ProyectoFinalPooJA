using ProyectoFinalPooJA.Formularios.General;
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
    public partial class ClienteViewForm : GeneralSearchForm
    {
        public ClienteViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ClienteCrearForm form = new ClienteCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClienteActualizarForm form = new ClienteActualizarForm();
            form.ShowDialog();

        }
    }
}
