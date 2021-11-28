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
    public partial class EmpleadoActualizarForm : Form
    {
        EmpleadoRepository _empleadoRepository = new EmpleadoRepository();
        public EmpleadoActualizarForm()
        {
            InitializeComponent();
            _empleadoRepository = new EmpleadoRepository();
            cbCargoEmpeladoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentoEmpeladoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoCrearModificar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoCrearModificar.Clear();
            txtCorreoEmpleadoModificar.Clear();
            txtIdentificacionEmpleadoModificar.Clear();
            txtNombreEmpleadoModificar.Clear();
            txtTelefonoEmpleadoModificar.Clear();
            cbDepartamentoEmpeladoModificar.SelectedIndex = 0;
            cbCargoEmpeladoModificar.SelectedIndex = 0;
            dpNacimientoEmpleadoModificar.Value = DateTime.Now;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoCrearModificar.Text) || string.IsNullOrWhiteSpace(txtCorreoEmpleadoModificar.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificacionEmpleadoModificar.Text) || string.IsNullOrWhiteSpace(txtNombreEmpleadoModificar.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoEmpleadoModificar.Text) || string.IsNullOrWhiteSpace(txtCodigoCrearModificar.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else if (dpNacimientoEmpleadoModificar.Value.Date == DateTime.Now.Date) MessageBox.Show("¡La fecha es obligatorio!");
            else if ((DateTime.Now.Subtract(dpNacimientoEmpleadoModificar.Value.Date).TotalDays / 365) < 18) MessageBox.Show("¡Debe ser mayor de edad!");
            else
            {
                var existencia = _empleadoRepository.ExisteEditar(txtIdentificacionEmpleadoModificar.Text.ToUpper(), txtCodigoCrearModificar.Text.ToUpper(), EmpleadoViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe ese modelo , favor de crear uno nuevo!");
                else
                {
                    var empleado = _empleadoRepository.Consultar(EmpleadoViewForm.ID)[0];

                    empleado.Nombre = txtNombreEmpleadoModificar.Text;
                    empleado.CargoID = int.Parse(cbCargoEmpeladoModificar.SelectedValue.ToString());
                    empleado.DepartamentoID = int.Parse(cbDepartamentoEmpeladoModificar.SelectedValue.ToString());
                    empleado.Cedula = txtIdentificacionEmpleadoModificar.Text;
                    empleado.Correo = txtCorreoEmpleadoModificar.Text;
                    empleado.Codigo_Empleado = int.Parse(txtCodigoCrearModificar.Text);
                    empleado.Fecha_Nacimiento = dpNacimientoEmpleadoModificar.Value.Date;
                    empleado.Telefono = txtTelefonoEmpleadoModificar.Text;
                    var resultado = _empleadoRepository.Actualizar(empleado);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }

        private void EmpleadoActualizarForm_Load(object sender, EventArgs e)
        {

            var departamentos = new DepartamentoRepository().Consultar(0);
            var cargos = new CargoRepository().Consultar(0);
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = departamentos;

            cbDepartamentoEmpeladoModificar.DataSource = bindingSource1.DataSource;
            cbDepartamentoEmpeladoModificar.DisplayMember = "Nombre";
            cbDepartamentoEmpeladoModificar.ValueMember = "ID";

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = cargos;

            cbCargoEmpeladoModificar.DataSource = bindingSource2.DataSource;

            cbCargoEmpeladoModificar.DisplayMember = "Nombre";
            cbCargoEmpeladoModificar.ValueMember = "ID";

            var datos = _empleadoRepository.Consultar(EmpleadoViewForm.ID)[0];
            txtCodigoCrearModificar.Text = datos.Codigo_Empleado.ToString();
            txtCorreoEmpleadoModificar.Text = datos.Correo;
            txtIdentificacionEmpleadoModificar.Text = datos.Cedula;
            txtNombreEmpleadoModificar.Text = datos.Nombre;
            txtTelefonoEmpleadoModificar.Text = datos.Telefono;
            dpNacimientoEmpleadoModificar.Value = datos.Fecha_Nacimiento;



            cbDepartamentoEmpeladoModificar.SelectedValue = datos.DepartamentoID;
            cbCargoEmpeladoModificar.SelectedValue = datos.CargoID;
            dpNacimientoEmpleadoModificar.Format = DateTimePickerFormat.Custom;
            dpNacimientoEmpleadoModificar.CustomFormat = "dd-MM-yyyy";
        }
    }
}
