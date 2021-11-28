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

namespace ProyectoFinalPooJA.Formularios.DepartamentoUI
{
    public partial class DepartamentoActualizarForm : Form
    {
        DepartamentoRepository _departamentoRepository;
        public DepartamentoActualizarForm()
        {
            InitializeComponent();
            _departamentoRepository = new DepartamentoRepository();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDepartamento.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartamento.Text)) MessageBox.Show("¡Los campos son obligatorio!");
            else
            {
                var existencia = _departamentoRepository.ExisteEditar(txtDepartamento.Text.ToUpper(), DepartamentoViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe ese departamento, favor de crear uno nuevo!");
                else
                {
                    var departamento = _departamentoRepository.Consultar(DepartamentoViewForm.ID)[0];
                    departamento.Nombre = txtDepartamento.Text;
                    var resultado = _departamentoRepository.Actualizar(departamento);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void DepartamentoActualizarForm_Load(object sender, EventArgs e)
        {
            var departamento = _departamentoRepository.Consultar(DepartamentoViewForm.ID)[0];
            txtDepartamento.Text = departamento.Nombre;
        }
    }
}
