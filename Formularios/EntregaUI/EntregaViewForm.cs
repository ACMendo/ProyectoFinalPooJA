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

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public partial class EntregaViewForm : GeneralSearchForm
    {
        public EntregaViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            EntregaCrearForm form = new EntregaCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EntregaActualizarForm form = new EntregaActualizarForm();
            form.ShowDialog();
        }
    }
}
