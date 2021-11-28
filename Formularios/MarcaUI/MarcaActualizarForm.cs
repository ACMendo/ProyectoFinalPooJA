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
    public partial class MarcaActualizarForm : Form
    {
        MarcaRepository _marcaRepository;
        public MarcaActualizarForm()
        {
            InitializeComponent();
            _marcaRepository = new MarcaRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMarcaActualizar.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarcaActualizar.Text)) MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _marcaRepository.ExisteEditar(txtMarcaActualizar.Text.ToUpper(), MarcaViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe otra marca , favor de crear uno nuevo!");
                else
                {
                    var marca = _marcaRepository.Consultar(MarcaViewForm.ID)[0];
                    marca.Nombre = txtMarcaActualizar.Text;
                    var resultado = _marcaRepository.Actualizar(marca);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void MarcaActualizarForm_Load(object sender, EventArgs e)
        {
            var marca = _marcaRepository.Consultar(MarcaViewForm.ID)[0];
            txtMarcaActualizar.Text = marca.Nombre;
        }
    }
}
