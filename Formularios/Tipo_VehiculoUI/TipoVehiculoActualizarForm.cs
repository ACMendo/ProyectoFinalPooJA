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
    public partial class TipoVehiculoActualizarForm : Form
    {
        Tipo_VehiculoRepository _tipo_VehiculoRepository;
        public TipoVehiculoActualizarForm()
        {
            InitializeComponent();
            _tipo_VehiculoRepository = new Tipo_VehiculoRepository();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcionTipoModificar.Clear();
            txtNombreTipoModificar.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionTipoModificar.Text) || string.IsNullOrWhiteSpace(txtNombreTipoModificar.Text)) MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _tipo_VehiculoRepository.ExisteEditar(txtNombreTipoModificar.Text.ToUpper(), TipoVehiculoViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe otro tipo de vehiculo , favor de crear uno nuevo!");
                else
                {
                    var tipo = _tipo_VehiculoRepository.Consultar(TipoVehiculoViewForm.ID)[0];
                    tipo.Nombre = txtNombreTipoModificar.Text;
                    tipo.Descripcion = txtDescripcionTipoModificar.Text;
                    var resultado = _tipo_VehiculoRepository.Actualizar(tipo);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void TipoVehiculoActualizarForm_Load(object sender, EventArgs e)
        {
            var datos = _tipo_VehiculoRepository.Consultar(TipoVehiculoViewForm.ID)[0];
            txtNombreTipoModificar.Text = datos.Nombre;
            txtDescripcionTipoModificar.Text = datos.Descripcion;
        }
    }
}
