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

namespace ProyectoFinalPooJA.Formularios.MarcaUI
{
    public partial class MarcaCrearForm : Form
    {
        MarcaRepository _marcaRepository;
        public MarcaCrearForm()
        {
            InitializeComponent();
            _marcaRepository = new MarcaRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMarcaCrear.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarcaCrear.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                Marca cargo = new Marca() { Nombre = txtMarcaCrear.Text };

                var existencia = _marcaRepository.ExisteCrear(txtMarcaCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe esa marca, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _marcaRepository.Crear(cargo);
                        MessageBox.Show("¡Marca creada exitosamente!");
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
