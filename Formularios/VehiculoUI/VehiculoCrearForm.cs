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

namespace ProyectoFinalPooJA.Formularios.VehiculoUI
{
    public partial class VehiculoCrearForm : Form
    {
        VehiculoRepository _vehiculoRepository;
        public VehiculoCrearForm()
        {
            InitializeComponent();
            _vehiculoRepository = new VehiculoRepository();
            cbxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo_Vehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTransmision.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtChasis.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
            cbxCombustible.SelectedIndex = 0;
            cbxColor.SelectedIndex = 0;
            cbxEmpleado.SelectedIndex = 0;
            cbxModelo.SelectedIndex = 0;
            cbxTipo_Vehiculo.SelectedIndex = 0;
            cbxTransmision.SelectedIndex = 0;
            checkMantenimiento.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void VehiculoCrearForm_Load(object sender, EventArgs e)
        {
            var color = new ColorRepository().Consultar(0);
            var empleado = new EmpleadoRepository().Consultar(0);
            var modelo = new ModeloRepository().Consultar(0);
            var tipoVehiculo = new Tipo_VehiculoRepository().Consultar(0);

            var colorBindingSource = new BindingSource();
            colorBindingSource.DataSource = color;
            cbxColor.DataSource = colorBindingSource.DataSource;
            cbxColor.DisplayMember = "Nombre";
            cbxColor.ValueMember = "ID";

            var empleadoBindingSource = new BindingSource();
            empleadoBindingSource.DataSource = empleado;
            cbxEmpleado.DataSource = empleadoBindingSource.DataSource;
            cbxEmpleado.DisplayMember = "Nombre";
            cbxEmpleado.ValueMember = "ID";

            var modeloBindingSource = new BindingSource();
            modeloBindingSource.DataSource = modelo;
            cbxModelo.DataSource = modeloBindingSource.DataSource;
            cbxModelo.DisplayMember = "Nombre";
            cbxModelo.ValueMember = "ID";

            var tipoBindingSource = new BindingSource();
            tipoBindingSource.DataSource = tipoVehiculo;
            cbxTipo_Vehiculo.DataSource = tipoBindingSource.DataSource;
            cbxTipo_Vehiculo.DisplayMember = "Nombre";
            cbxTipo_Vehiculo.ValueMember = "ID";

            checkMantenimiento.Enabled = false;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAno.Text) || string.IsNullOrWhiteSpace(txtChasis.Text) ||
               string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(cbxColor.Text) ||
               string.IsNullOrWhiteSpace(cbxModelo.Text) || string.IsNullOrWhiteSpace(cbxTipo_Vehiculo.Text) ||
               string.IsNullOrWhiteSpace(cbxTransmision.Text) || string.IsNullOrWhiteSpace(cbxTipo_Vehiculo.Text) ||
               string.IsNullOrWhiteSpace(cbxEmpleado.Text) )
                MessageBox.Show("¡El campo es obligatorio!");          
            else
            {

                Vehiculo vehiculo = new Vehiculo()
                {
                    Anio = txtAno.Text,
                    Chasis = txtChasis.Text,
                    Placa = txtPlaca.Text,
                    ModeloID = int.Parse(cbxModelo.SelectedValue.ToString()),
                    ColorID = int.Parse(cbxColor.SelectedValue.ToString()),
                    EmpleadoID = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    Tipo_VehiculoID = int.Parse(cbxTipo_Vehiculo.SelectedValue.ToString()),
                    Combustible = cbxCombustible.Text,
                    Mantenimiento = false,
                    Transmision = cbxTransmision.Text
                };

                var existencia = _vehiculoRepository.ExisteCrear(txtChasis.Text.ToUpper(), txtPlaca.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese vehículo, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _vehiculoRepository.Crear(vehiculo);
                        MessageBox.Show("¡Vehículo creado exitosamente!");
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
