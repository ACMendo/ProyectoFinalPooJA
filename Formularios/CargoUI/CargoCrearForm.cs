using ProyectoFinalPooJA.Formularios.General;
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


namespace ProyectoFinalPooJA.Formularios.CargoUI
{
    public partial class CargoCrearForm : Form
    {
        CargoRepository _cargoRepository = new CargoRepository();
        public CargoCrearForm()
        {
            InitializeComponent();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargoCrear.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Cargo cargo = new Cargo()
                {
                    Nombre = txtCargoCrear.Text
                };

                var existencia = _cargoRepository.BuscarPorNombre(txtCargoCrear.Text);

                if (existencia.Count == 0 || existencia == null)
                {
                    _cargoRepository.Crear(cargo);
                    MessageBox.Show("¡Cargo creado exitosamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Ya existe ese cargo, favor de crear uno nuevo!");
                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCargoCrear.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
