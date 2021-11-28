using ProyectoFinalPooJA.Formularios.ColorUI;
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

namespace ProyectoFinalPooJA.Formularios.ColorUI
{
    public partial class ColorViewForm : GeneralSearchForm
    {
        ColorRepository _colorRepository;
        public static int ID = 0;
        public ColorViewForm()
        {
            InitializeComponent();
            _colorRepository = new ColorRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ColorCrearForm form = new ColorCrearForm();
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
                ColorActualizarForm form = new ColorActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }

        }

        private void ColorViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }

        public void Cargardgv()
        {
            dgvColor.DataSource = _colorRepository.Consultar(0);
            dgvColor.Columns["ID"].Visible = false;
            dgvColor.Columns["Borrado"].Visible = false;
            dgvColor.Columns["Estatus"].Visible = false;
            dgvColor.Columns["Fecha_Registro"].Visible = false;
            dgvColor.Columns["Fecha_Modificacion"].Visible = false;
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
                dgvColor.DataSource = _colorRepository.Filtro(txtFiltro.Text.ToUpper());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Color", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _colorRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void dgvColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvColor.CurrentRow.Cells["ID"].Value.ToString());
        }
    }
}
