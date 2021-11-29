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

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public partial class EntregaCrearForm : Form
    {
        EntregaRepository _entregaRepository;
        public EntregaCrearForm()
        {
            InitializeComponent();
            _entregaRepository = new EntregaRepository();
            cbxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Clear();
            txtDescripcion.Clear();
            txtPeso.Clear();
            cbxCliente.SelectedIndex = 0;
            cbxEmpleado.SelectedIndex = 0;
            cbxPrioridad.SelectedIndex = 0;
            dtpFechaRegreso.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntregaCrearForm_Load(object sender, EventArgs e)
        {
            var prioridad = new PrioridadRepository().Consultar(0);
            var empleado = new EmpleadoRepository().Consultar(0);
            var cliente = new ClienteRepository().Consultar(0);

            var prioridadBindingSource = new BindingSource();
            prioridadBindingSource.DataSource = prioridad;
            cbxPrioridad.DataSource = prioridadBindingSource.DataSource;
            cbxPrioridad.DisplayMember = "Nombre";
            cbxPrioridad.ValueMember = "ID";

            var empleadoBindingSource = new BindingSource();
            empleadoBindingSource.DataSource = empleado;
            cbxEmpleado.DataSource = empleadoBindingSource.DataSource;
            cbxEmpleado.DisplayMember = "Nombre";
            cbxEmpleado.ValueMember = "ID";

            var clienteBindingSource = new BindingSource();
            clienteBindingSource.DataSource = cliente;
            cbxCliente.DataSource = clienteBindingSource.DataSource;
            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "ID";

            //var datos = _entregaRepository.Consultar(EntregaViewForm.ID);
            dtpFechaRegreso.Format = DateTimePickerFormat.Custom;
            dtpFechaRegreso.CustomFormat = "dd-MM-yyyy";
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.CustomFormat = "dd-MM-yyyy";
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDestino.Text) ||
             string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(cbxCliente.Text) ||
             string.IsNullOrWhiteSpace(cbxEmpleado.Text) || string.IsNullOrWhiteSpace(cbxPrioridad.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else if (dtpFechaSalida.Value.Date > dtpFechaRegreso.Value.Date) MessageBox.Show("¡Fechas Incorrectas!");
            else
            {
                Entrega empleado = new Entrega()
                {
                    Descripcion = txtDescripcion.Text,
                    ClienteID = int.Parse(cbxCliente.SelectedValue.ToString()),
                    EmpleadoID = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    Destino = txtDestino.Text,
                    PrioridadID = int.Parse(cbxPrioridad.SelectedValue.ToString()),
                    Fecha_Salida = dtpFechaSalida.Value.Date,
                    Fecha_Regreso = dtpFechaRegreso.Value.Date,
                    Peso = decimal.Parse(txtPeso.Text)
                };
                try
                {
                    _entregaRepository.Crear(empleado);
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
