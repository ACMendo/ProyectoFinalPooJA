using ProyectoFinalPooJA.Datos.Entities;
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
    public partial class ModelosCrearForm : Form
    {
        ModeloRepository _modeloRepository;
        public ModelosCrearForm()
        {
            InitializeComponent();
            _modeloRepository = new ModeloRepository();
            cbMarcaCrear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModelosCrearForm_Load(object sender, EventArgs e)
        {

            var marcas = new MarcaRepository().Consultar(0);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = marcas;

            cbMarcaCrear.DataSource = bindingSource1.DataSource;

            cbMarcaCrear.DisplayMember = "Nombre";
            cbMarcaCrear.ValueMember = "ID";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreModeloCrear.Clear();
            cbMarcaCrear.SelectedIndex = 0;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreModeloCrear.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Modelo modelo = new Modelo() { Nombre = txtNombreModeloCrear.Text, MarcaID = int.Parse(cbMarcaCrear.SelectedValue.ToString()) };

                var existencia = _modeloRepository.ExisteCrear(txtNombreModeloCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese modelo, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _modeloRepository.Crear(modelo);
                        MessageBox.Show("¡Modelo creado exitosamente!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }
    }
}
