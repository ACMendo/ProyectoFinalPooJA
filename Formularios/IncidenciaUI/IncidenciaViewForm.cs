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

namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    public partial class IncidenciaViewForm : GeneralSearchForm
    {
        public IncidenciaViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            IncidenciaCrearForm form = new IncidenciaCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IncidenciaActualizarForm form = new IncidenciaActualizarForm();
            form.ShowDialog();
        }
    }
}
