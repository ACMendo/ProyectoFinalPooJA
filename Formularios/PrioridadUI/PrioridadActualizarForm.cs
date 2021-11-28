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
    public partial class PrioridadActualizarForm : Form
    {
        PrioridadRepository _prioridadRepository;
        public PrioridadActualizarForm()
        {
            InitializeComponent();
            _prioridadRepository = new PrioridadRepository();
            cbHorasModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePrioridadModificar.Clear();
            cbHorasModificar.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePrioridadModificar.Text) || cbHorasModificar.Text=="0") MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _prioridadRepository.ExisteEditar(txtNombrePrioridadModificar.Text.ToUpper(), PrioridadViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe otra prioridad , favor de crear uno nuevo!");
                else
                {
                    var tipo = _prioridadRepository.Consultar(PrioridadViewForm.ID)[0];
                    tipo.Nombre = txtNombrePrioridadModificar.Text;
                    tipo.Horas = int.Parse(cbHorasModificar.Text);
                    var resultado = _prioridadRepository.Actualizar(tipo);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void PrioridadActualizarForm_Load(object sender, EventArgs e)
        {
            var datos = _prioridadRepository.Consultar(PrioridadViewForm.ID)[0];
            txtNombrePrioridadModificar.Text = datos.Nombre;
            cbHorasModificar.Text = datos.Horas.ToString();
        }
    }
}
