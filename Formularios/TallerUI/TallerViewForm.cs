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

namespace ProyectoFinalPooJA.Formularios.TallerUI
{
    public partial class TallerViewForm : GeneralSearchForm
    {
        TallerRepository _tallerRepository;
        public static int ID = 0;
        public TallerViewForm()
        {
            InitializeComponent();
            _tallerRepository = new TallerRepository();
        }
        void Cargardgv()
        {
            _tallerRepository = new TallerRepository();
            dgvTaller.DataSource = _tallerRepository.Consultar(0);
            dgvTaller.Columns["ID"].Visible = false;
            dgvTaller.Columns["Borrado"].Visible = false;
            dgvTaller.Columns["Estatus"].Visible = false;
            dgvTaller.Columns["Fecha_Registro"].Visible = false;
            dgvTaller.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void TallerViewForm_Load(object sender, EventArgs e)
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
            else dgvTaller.DataSource = _tallerRepository.Filtro(txtFiltro.Text.ToUpper());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Taller", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _tallerRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void dgvTaller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvTaller.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            TallerCrearForm form = new TallerCrearForm();
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
                TallerActualizarForm form = new TallerActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }
        }
    }
}
