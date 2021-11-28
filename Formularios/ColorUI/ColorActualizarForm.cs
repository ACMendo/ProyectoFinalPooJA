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
    public partial class ColorActualizarForm : Form
    {
        ColorRepository _colorRepository;
        public ColorActualizarForm()
        {
            InitializeComponent();
            _colorRepository = new ColorRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColor.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text)) MessageBox.Show("¡Los campos son obligatorio!");
            else
            {
                var existencia = _colorRepository.ExisteEditar(txtColor.Text.ToUpper(), ColorViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe ese color, favor de crear uno nuevo!");
                else
                {
                    var color = _colorRepository.Consultar(ColorViewForm.ID)[0];
                    color.Nombre = txtColor.Text;
                    var resultado = _colorRepository.Actualizar(color);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void ColorActualizarForm_Load(object sender, EventArgs e)
        {
            var color = _colorRepository.Consultar(ColorViewForm.ID)[0];
            txtColor.Text = color.Nombre;

        }
    }
}
