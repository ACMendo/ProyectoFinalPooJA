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

namespace ProyectoFinalPooJA.Formularios.DepartamentoUI
{
    public partial class DepartamentoViewForm : GeneralSearchForm
    {
        DepartamentoRepository _departamentoRepository;
        public static int ID = 0;
        public DepartamentoViewForm()
        {
            InitializeComponent();
            _departamentoRepository = new DepartamentoRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DepartamentoCrearForm form = new DepartamentoCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                DepartamentoActualizarForm form = new DepartamentoActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }
        }
        public void Cargardgv()
        {
            _departamentoRepository = new DepartamentoRepository();
            dgvDepartamento.DataSource = _departamentoRepository.Consultar(0);
            dgvDepartamento.Columns["ID"].Visible = false;
            dgvDepartamento.Columns["Borrado"].Visible = false;
            dgvDepartamento.Columns["Estatus"].Visible = false;
            dgvDepartamento.Columns["Fecha_Registro"].Visible = false;
            dgvDepartamento.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else
            {
                dgvDepartamento.DataSource = _departamentoRepository.Filtro(txtFiltro.Text.ToUpper());
            }
        }

        private void DepartamentoViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvDepartamento.ReadOnly = true;
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvDepartamento.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de borrar?", "Borrar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _departamentoRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }
    }
}
