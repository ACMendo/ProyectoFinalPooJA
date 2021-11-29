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
    public partial class TallerActualizarForm : Form
    {
        TallerRepository _tallerRepository;
        public TallerActualizarForm()
        {
            InitializeComponent();
            _tallerRepository = new TallerRepository();
        }

        private void TallerActualizarForm_Load(object sender, EventArgs e)
        {
            var datos = _tallerRepository.Consultar(TallerViewForm.ID)[0];
            txtTelefonoTallerModificar.Text = datos.Telefono;
            txtNombreTallerModificar.Text = datos.Nombre;
            txtDireccionTallerModificar.Text = datos.Direccion;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccionTallerModificar.Clear();
            txtNombreTallerModificar.Clear();
            txtTelefonoTallerModificar.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreTallerModificar.Text) || string.IsNullOrWhiteSpace(txtDireccionTallerModificar.Text)
                || string.IsNullOrWhiteSpace(txtTelefonoTallerModificar.Text)
                ) MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _tallerRepository.ExisteEditar(txtNombreTallerModificar.Text.ToUpper(), TallerViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe ese taller, favor de crear uno nuevo!");
                else
                {
                    var taller = _tallerRepository.Consultar(TallerViewForm.ID)[0];
                    taller.Nombre = txtNombreTallerModificar.Text;
                    taller.Direccion = txtDireccionTallerModificar.Text;
                    taller.Telefono = txtTelefonoTallerModificar.Text;
                    var resultado = _tallerRepository.Actualizar(taller);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }
    }
}
