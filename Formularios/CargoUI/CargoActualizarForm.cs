using ProyectoFinalPooJA.Datos.Entities;
using ProyectoFinalPooJA.Formularios.MenuPrincipal;
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
    public partial class CargoActualizarForm : Form
    {
        CargoRepository _cargoRepository = new CargoRepository();
        public CargoActualizarForm()
        {
            InitializeComponent();
            txtCargoActualizar.Text = _cargoRepository.Consultar(CargoViewForm.ID)[0].Nombre;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargoActualizar.Text)) MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var cargo = _cargoRepository.Consultar(CargoViewForm.ID)[0];
                cargo.Nombre = txtCargoActualizar.Text;
                var resultado = _cargoRepository.Actualizar(cargo);
                MessageBox.Show(resultado.Message);
                if (resultado.Success)  this.Close();
            }
            //CargoViewForm cargoViewForm = new CargoViewForm();
            //this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCargoActualizar.Clear();
        }
    }
}
