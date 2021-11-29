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

namespace ProyectoFinalPooJA.Formularios.PrioridadUI
{
    public partial class PrioridadViewForm : GeneralSearchForm
    {
        PrioridadRepository _prioridadRepository;
        public static int ID = 0;
        public PrioridadViewForm()
        {
            InitializeComponent();
            _prioridadRepository = new PrioridadRepository();
        }

        private void PrioridadViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvPrioridad.ReadOnly = true;
        }
        void Cargardgv()
        {
            _prioridadRepository = new PrioridadRepository();
            dgvPrioridad.DataSource = _prioridadRepository.Consultar(0);
            dgvPrioridad.Columns["ID"].Visible = false;
            dgvPrioridad.Columns["Borrado"].Visible = false;
            dgvPrioridad.Columns["Estatus"].Visible = false;
            dgvPrioridad.Columns["Fecha_Registro"].Visible = false;
            dgvPrioridad.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void dgvPrioridad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvPrioridad.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de borrar?", "Borrar Prioridad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _prioridadRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else dgvPrioridad.DataSource = _prioridadRepository.Filtro(txtFiltro.Text.ToUpper());
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            PrioridadCrearForm form = new PrioridadCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                PrioridadActualizarForm form = new PrioridadActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }
        }
    }
}
