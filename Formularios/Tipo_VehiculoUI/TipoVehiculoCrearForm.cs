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

namespace ProyectoFinalPooJA.Formularios.Tipo_VehiculoUI
{
    public partial class TipoVehiculoCrearForm : Form
    {
        Tipo_VehiculoRepository _tipo_VehiculoRepository;
        public TipoVehiculoCrearForm()
        {
            InitializeComponent();
            _tipo_VehiculoRepository = new Tipo_VehiculoRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescricionCrear.Clear();
            txtNombreTipoVehicuoCrear.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTipoVehicuoCrear.Text) || string.IsNullOrWhiteSpace(txtDescricionCrear.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Tipo_Vehiculo tipoVehiculo = new Tipo_Vehiculo() { Nombre = txtNombreTipoVehicuoCrear.Text, Descripcion = txtDescricionCrear.Text };

                var existencia = _tipo_VehiculoRepository.ExisteCrear(txtNombreTipoVehicuoCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese tipo de vehiculo, favor de crear uno nuevo!");
                else
                {
                    try
                    {   
                        _tipo_VehiculoRepository.Crear(tipoVehiculo);
                        MessageBox.Show("¡Tipo de vehiculo creado exitosamente!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
