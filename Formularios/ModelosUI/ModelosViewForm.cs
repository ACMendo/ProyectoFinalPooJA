using ProyectoFinalPooJA.Datos.Entities;
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

namespace ProyectoFinalPooJA.Formularios.ModelosUI
{
    public partial class ModelosViewForm : GeneralSearchForm
    {
        ModeloRepository _modeloRepository;
        public static int ID = 0;
        public ModelosViewForm()
        {
            InitializeComponent();
            _modeloRepository = new ModeloRepository();
        }

        private void dgvModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvModelo.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ModelosCrearForm form = new ModelosCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                ModeloActualizarForm form = new ModeloActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
            ID = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                if (MessageBox.Show("¿Está seguro de borrar?", "Borrar Modelo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _modeloRepository.Borrar(ID);
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
            else
            {
                var datos = _modeloRepository.Filtro(txtFiltro.Text.ToUpper());
                dgvModelo.DataSource = MapeoModelo(datos);
            }
        }
        public void Cargardgv()
        {
            _modeloRepository = new ModeloRepository();
            var datos = _modeloRepository.ConsultarGenery(0, x => x.Marca).ToList();
            dgvModelo.DataSource = MapeoModelo(datos);
            dgvModelo.Columns["ID"].Visible = false;
            dgvModelo.Columns["MarcaID"].Visible = false;
            //dgvModelo.Columns["Borrado"].Visible = false;
            //dgvModelo.Columns["Estatus"].Visible = false;
            //dgvModelo.Columns["Fecha_Registro"].Visible = false;
            //dgvModelo.Columns["Fecha_Modificacion"].Visible = false;

        }

        List<ModeloView> MapeoModelo(List<Modelo> datos)
        {
            var lista = new List<ModeloView>();
            foreach (var item in datos)
            {
                lista.Add(new ModeloView
                {
                    Nombre = item.Nombre,
                   
                    ID = item.ID,
                    Marca = item.Marca.Nombre,
                    MarcaID = item.MarcaID,
                });
            }
            return lista;
        }

        private void ModelosViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvModelo.ReadOnly = true;
        }
    }
}
