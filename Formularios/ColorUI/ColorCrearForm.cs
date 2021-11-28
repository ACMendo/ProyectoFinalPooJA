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

namespace ProyectoFinalPooJA.Formularios.ColorUI
{
    public partial class ColorCrearForm : Form
    {
        ColorRepository _colorRepository;
        public ColorCrearForm()
        {
            InitializeComponent();
            _colorRepository = new ColorRepository();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColor.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text)) MessageBox.Show("¡Los campos son obligatorio!");
            else
            {
                var existencia = _colorRepository.ExisteCrear(txtColor.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese color, favor de crear uno nuevo!");
                else
                {
                    Datos.Entities.Color color = new Datos.Entities.Color() { Nombre = txtColor.Text };
                    try
                    {
                        _colorRepository.Crear(color);
                        MessageBox.Show("¡Color creado correctamente!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }

        private void ColorCrearForm_Load(object sender, EventArgs e)
        {

        }
    }
}
