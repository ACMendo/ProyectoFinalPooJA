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

namespace ProyectoFinalPooJA.Formularios.DepartamentoUI
{
    public partial class DepartamentoCrearForm : Form
    {
        DepartamentoRepository _departamentoRepository;
        public DepartamentoCrearForm()
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartamento.Text)) MessageBox.Show("¡Los campos son obligatorio!");
            else
            {
                var existencia = _departamentoRepository.ExisteCrear(txtDepartamento.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese departamento, favor de crear uno nuevo!");
                else
                {
                    Departamento departamento = new Departamento() { Nombre = txtDepartamento.Text };
                    try
                    {
                        _departamentoRepository.Crear(departamento);
                        MessageBox.Show("¡Departamento creado correctamente!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }

        private void DepartamentoCrearForm_Load(object sender, EventArgs e)
        {

        }
    }
}
