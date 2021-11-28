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

namespace ProyectoFinalPooJA.Formularios.EmpleadoUI
{
    public partial class EmpleadoCrearForm : Form
    {
        EmpleadoRepository _empleadoRepository;
        public EmpleadoCrearForm()
        {
            InitializeComponent();
            _empleadoRepository = new EmpleadoRepository();
            cbCargoEmpeladoCrear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoEmpeladoCrear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtCodigoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoEmpleadoCrear.Clear(); 
            txtCorreoEmpleadoCrear.Clear(); 
            txtIdentificacionEmpleadoCrear.Clear(); 
            txtNombreCrearEmpleado.Clear(); 
            txtTelefonoEmpleadoCrear.Clear();
            cbDepartamentoEmpeladoCrear.SelectedIndex = 0;
            cbCargoEmpeladoCrear.SelectedIndex = 0;
            dpNacimientoEmpleadoCrear.Value=DateTime.Now;

        }

        private void EmpleadoCrearForm_Load(object sender, EventArgs e)
        {
            var departamentos = new DepartamentoRepository().Consultar(0);
            var cargos = new CargoRepository().Consultar(0);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = departamentos;
            cbDepartamentoEmpeladoCrear.DataSource = bindingSource1.DataSource;
            cbDepartamentoEmpeladoCrear.DisplayMember = "Nombre";
            cbDepartamentoEmpeladoCrear.ValueMember = "ID";

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = cargos;
            cbCargoEmpeladoCrear.DataSource = bindingSource2.DataSource;
            cbCargoEmpeladoCrear.DisplayMember = "Nombre";
            cbCargoEmpeladoCrear.ValueMember = "ID";
            dpNacimientoEmpleadoCrear.Format = DateTimePickerFormat.Custom;
            dpNacimientoEmpleadoCrear.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoEmpleadoCrear.Text) || string.IsNullOrWhiteSpace(txtCorreoEmpleadoCrear.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificacionEmpleadoCrear.Text) || string.IsNullOrWhiteSpace(txtNombreCrearEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoEmpleadoCrear.Text) || string.IsNullOrWhiteSpace(txtCodigoEmpleadoCrear.Text)  )
                MessageBox.Show("¡El campo es obligatorio!");
            else if(dpNacimientoEmpleadoCrear.Value.Date == DateTime.Now.Date) MessageBox.Show("¡La fecha es obligatorio!");
            else if((DateTime.Now.Subtract(dpNacimientoEmpleadoCrear.Value.Date).TotalDays /365) <18) MessageBox.Show("¡Debe ser mayor de edad!");
            else
            {

                Empleado empleado = new Empleado() { 
                    Nombre = txtNombreCrearEmpleado.Text,
                    CargoID = int.Parse(cbCargoEmpeladoCrear.SelectedValue.ToString()),
                    DepartamentoID = int.Parse(cbDepartamentoEmpeladoCrear.SelectedValue.ToString()),
                    Cedula=txtIdentificacionEmpleadoCrear.Text,
                    Correo=txtCorreoEmpleadoCrear.Text,
                    Codigo_Empleado= int.Parse(txtCodigoEmpleadoCrear.Text),
                    Fecha_Ingreso = DateTime.Now,
                    Fecha_Nacimiento= dpNacimientoEmpleadoCrear.Value.Date,
                    Telefono = txtTelefonoEmpleadoCrear.Text
                    
                };

                var existencia = _empleadoRepository.ExisteCrear(txtIdentificacionEmpleadoCrear.Text.ToUpper(), txtCodigoEmpleadoCrear.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese empleado, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _empleadoRepository.Crear(empleado);
                        MessageBox.Show("¡Empleado creado exitosamente!");
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
