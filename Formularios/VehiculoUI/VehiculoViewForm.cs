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

namespace ProyectoFinalPooJA.Formularios.VehiculoUI
{
    public partial class VehiculoViewForm : GeneralSearchForm
    {
        public VehiculoViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            VehiculoCrearForm form = new VehiculoCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VehiculoActualizarForm form = new VehiculoActualizarForm();
            form.ShowDialog();
        }
    }
}
