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

namespace ProyectoFinalPooJA.Formularios.PrioridadUI
{
    public partial class PrioridadCrearForm : Form
    {
        PrioridadRepository _prioridadRepository;
        public PrioridadCrearForm()
        {
            InitializeComponent();
            _prioridadRepository = new PrioridadRepository();
            cbHoras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePrioridadCrear.Clear();
            cbHoras.Text = "0";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePrioridadCrear.Text) || cbHoras.Text == "0")
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Prioridad prioridad = new Prioridad() { Nombre = txtNombrePrioridadCrear.Text, Horas = int.Parse(cbHoras.Text) };

                var existencia = _prioridadRepository.ExisteCrear(txtNombrePrioridadCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe esa prioridad, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _prioridadRepository.Crear(prioridad);
                        MessageBox.Show("¡Prioridad creada exitosamente!");
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
