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
        CargoRepository _cargoRepository;
        public static int ID = 0;
        public CargoViewForm()
        {
            InitializeComponent();
            _cargoRepository = new CargoRepository();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CargoViewForm.ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Cargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _cargoRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            CargoCrearForm form = new CargoCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (CargoViewForm.ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                CargoActualizarForm form = new CargoActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
        }

        private void CargoViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }

        public void Cargardgv()
        {
            dgvCargo.DataSource = _cargoRepository.Consultar(0);
            InvisibleColumn();
        }

        public void InvisibleColumn()
        {
            dgvCargo.Columns["Borrado"].Visible = false;
            dgvCargo.Columns["Estatus"].Visible = false;
            dgvCargo.Columns["Fecha_Registro"].Visible = false;
            dgvCargo.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else dgvCargo.DataSource = _cargoRepository.BuscarPorNombre(txtFiltro.Text.ToUpper());
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvCargo.CurrentRow.Cells["ID"].Value.ToString());
        }
    }
}
