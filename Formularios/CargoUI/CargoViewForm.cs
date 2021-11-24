using ProyectoFinalPooJA.Formularios.General;
using ProyectoFinalPooJA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPooJA.Formularios.CargoUI
{
    public partial class CargoViewForm : GeneralSearchForm
    {
        CargoRepository _cargoRepository = new CargoRepository();
        public CargoViewForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            CargoCrearForm form = new CargoCrearForm();
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CargoActualizarForm form = new CargoActualizarForm();
            form.ShowDialog();

        }

        private void CargoViewForm_Load(object sender, EventArgs e)
        {
            //dgvCargo.DataSource = _cargoRepository.BuscarPorNombre();
            InvisibleColumn();

        }
        public void InvisibleColumn()
        {
            dgvCargo.Columns["Borrado"].Visible = false;
            dgvCargo.Columns["Estatus"].Visible = false;
            dgvCargo.Columns["Fecha_Registro"].Visible = false;
            dgvCargo.Columns["Fecha_Modificacion"].Visible = false;
        }
    }
}
