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

namespace ProyectoFinalPooJA.Formularios.MarcaUI
{
    public partial class MarcaViewForm : GeneralSearchForm
    {
        MarcaRepository _marcaRepository;
        public static int ID = 0;
        public MarcaViewForm()
        {
            InitializeComponent();
            _marcaRepository = new MarcaRepository();
        }

        private void MarcaViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvMarca.ReadOnly = true;
        }
        public void Cargardgv()
        {
            _marcaRepository = new MarcaRepository();
            dgvMarca.DataSource = _marcaRepository.Consultar(0);
            dgvMarca.Columns["ID"].Visible = false;
            dgvMarca.Columns["Borrado"].Visible = false;
            dgvMarca.Columns["Estatus"].Visible = false;
            dgvMarca.Columns["Fecha_Registro"].Visible = false;
            dgvMarca.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MarcaCrearForm form = new MarcaCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else dgvMarca.DataSource = _marcaRepository.Filtro(txtFiltro.Text.ToUpper());
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvMarca.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Marca", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _marcaRepository.Borrar(ID);
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
                MarcaActualizarForm form = new MarcaActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }
        }
    }
}
