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

namespace ProyectoFinalPooJA.Formularios.Tipo_VehiculoUI
{
    public partial class TipoVehiculoViewForm : GeneralSearchForm
    {
        Tipo_VehiculoRepository _tipo_VehiculoRepository;
        public static int ID =0;
        public TipoVehiculoViewForm()
        {
            InitializeComponent();
            _tipo_VehiculoRepository = new Tipo_VehiculoRepository();
        }

        private void dgvTipoVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvTipoVehiculo.CurrentRow.Cells["ID"].Value.ToString());
        }

        void Cargardgv()
        {
            _tipo_VehiculoRepository = new Tipo_VehiculoRepository();
            dgvTipoVehiculo.DataSource = _tipo_VehiculoRepository.Consultar(0);
            dgvTipoVehiculo.Columns["ID"].Visible = false;
            dgvTipoVehiculo.Columns["Borrado"].Visible = false;
            dgvTipoVehiculo.Columns["Estatus"].Visible = false;
            dgvTipoVehiculo.Columns["Fecha_Registro"].Visible = false;
            dgvTipoVehiculo.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void TipoVehiculoViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else dgvTipoVehiculo.DataSource = _tipo_VehiculoRepository.Filtro(txtFiltro.Text.ToUpper());
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            TipoVehiculoCrearForm form = new TipoVehiculoCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Tipo de Vehiculo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _tipo_VehiculoRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                TipoVehiculoActualizarForm form = new TipoVehiculoActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }
        }
    }
}
