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
    public partial class VehiculoActualizarForm : Form
    {
        VehiculoRepository _vehiculoRepository;
        public VehiculoActualizarForm()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void VehiculoActualizarForm_Load(object sender, EventArgs e)
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

            var datos = _vehiculoRepository.Consultar(VehiculoViewForm.ID)[0];
            txtAno.Text = datos.Anio;
            txtChasis.Text = datos.Chasis;
            txtPlaca.Text = datos.Placa;
            cbxColor.SelectedValue = datos.ColorID;
            cbxCombustible.Text = datos.Combustible;
            cbxEmpleado.SelectedValue = datos.EmpleadoID;
            cbxModelo.SelectedValue = datos.ModeloID;
            cbxTipo_Vehiculo.SelectedValue = datos.Tipo_VehiculoID;
            cbxTransmision.Text = datos.Transmision;
            checkMantenimiento.Checked = datos.Mantenimiento;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAno.Text) || string.IsNullOrWhiteSpace(txtChasis.Text) ||
              string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(cbxColor.Text) ||
              string.IsNullOrWhiteSpace(cbxModelo.Text) || string.IsNullOrWhiteSpace(cbxTipo_Vehiculo.Text) ||
              string.IsNullOrWhiteSpace(cbxTransmision.Text) || string.IsNullOrWhiteSpace(cbxTipo_Vehiculo.Text) ||
              string.IsNullOrWhiteSpace(cbxEmpleado.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else
            {
                var existencia = _vehiculoRepository.ExisteEditar(txtChasis.Text.ToUpper(), txtPlaca.Text.ToUpper(), VehiculoViewForm.ID);

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese vehiculo, favor de crear uno nuevo!");
                else
                {
                    var vehiculo = _vehiculoRepository.Consultar(VehiculoViewForm.ID)[0];
                    vehiculo.Anio = txtAno.Text;
                    vehiculo.Chasis = txtChasis.Text;
                    vehiculo.Placa = txtPlaca.Text;
                    vehiculo.ModeloID = int.Parse(cbxModelo.SelectedValue.ToString());
                    vehiculo.ColorID = int.Parse(cbxColor.SelectedValue.ToString());
                    vehiculo.EmpleadoID = int.Parse(cbxEmpleado.SelectedValue.ToString());
                    vehiculo.Tipo_VehiculoID = int.Parse(cbxTipo_Vehiculo.SelectedValue.ToString());
                    vehiculo.Combustible = cbxCombustible.Text;
                    vehiculo.Mantenimiento = checkMantenimiento.Checked;
                    vehiculo.Transmision = cbxTransmision.Text;
                    var resultado = _vehiculoRepository.Actualizar(vehiculo);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }
    }
}
