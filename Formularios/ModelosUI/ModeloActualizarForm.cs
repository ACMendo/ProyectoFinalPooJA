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
    public partial class ModeloActualizarForm : Form
    {
        ModeloRepository _modeloRepository;
        public ModeloActualizarForm()
        {
            InitializeComponent();
            _modeloRepository = new ModeloRepository();
            cbMarcaModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModeloActualizarForm_Load(object sender, EventArgs e)
        {
            var datos = _modeloRepository.Consultar(ModelosViewForm.ID)[0];
            txtNombrePrioridadModificar.Text = datos.Nombre;
            var marcas = new MarcaRepository().Consultar(0);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = marcas;
            cbMarcaModificar.DataSource = bindingSource1.DataSource;
            cbMarcaModificar.DisplayMember = "Nombre";
            cbMarcaModificar.ValueMember = "ID";

            cbMarcaModificar.SelectedValue = datos.MarcaID;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePrioridadModificar.Clear();
            cbMarcaModificar.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePrioridadModificar.Text) ) MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _modeloRepository.ExisteEditar(txtNombrePrioridadModificar.Text.ToUpper(), ModelosViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe ese modelo , favor de crear uno nuevo!");
                else
                {
                    var modelo = _modeloRepository.Consultar(ModelosViewForm.ID)[0];
                    modelo.Nombre = txtNombrePrioridadModificar.Text;
                    modelo.MarcaID = int.Parse(cbMarcaModificar.SelectedValue.ToString());
                    var resultado = _modeloRepository.Actualizar(modelo);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }
    }
}
