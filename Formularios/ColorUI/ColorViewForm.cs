using ProyectoFinalPooJA.Formularios.ColorUI;
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

namespace ProyectoFinalPooJA.Formularios.ColorUI
{
    public partial class ColorViewForm : GeneralSearchForm
    {
        public ColorViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ColorCrearForm form = new ColorCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ColorActualizarForm form = new ColorActualizarForm();
            form.ShowDialog();

        }
    }
}
