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

namespace ProyectoFinalPooJA.Formularios.TallerUI
{
    public partial class TallerCrearForm : Form
    {
        TallerRepository _tallerRepository;
        public TallerCrearForm()
        {
            InitializeComponent();
            _tallerRepository = new TallerRepository();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccionCrear.Clear();
            txtNombreTallerCrear.Clear();
            txtTelefonoTallerCrear.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTallerCrear.Text) || string.IsNullOrWhiteSpace(txtDireccionCrear.Text) || string.IsNullOrWhiteSpace(txtTelefonoTallerCrear.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Taller taller = new Taller()
                {
                    Nombre = txtNombreTallerCrear.Text,
                    Direccion = txtDireccionCrear.Text,
                    Telefono = txtTelefonoTallerCrear.Text
                };

                var existencia = _tallerRepository.ExisteCrear(txtNombreTallerCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese taller, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _tallerRepository.Crear(taller);
                        MessageBox.Show("¡Taller creado exitosamente!");
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
