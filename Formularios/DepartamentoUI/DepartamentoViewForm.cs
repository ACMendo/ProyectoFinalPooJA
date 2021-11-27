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

namespace ProyectoFinalPooJA.Formularios.DepartamentoUI
{
    public partial class DepartamentoViewForm : GeneralSearchForm
    {
        public DepartamentoViewForm()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DepartamentoCrearForm form = new DepartamentoCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DepartamentoActualizarForm form = new DepartamentoActualizarForm();
            form.ShowDialog();

        }
    }
}
