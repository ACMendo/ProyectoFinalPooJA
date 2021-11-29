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

namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    public partial class IncidenciaCrearForm : Form
    {
        IncidenciaRepository _incidenciaRepository;
        public IncidenciaCrearForm()
        {
            InitializeComponent();
            _incidenciaRepository = new IncidenciaRepository();
            cbxTaller.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
            cbxTaller.SelectedIndex = 0;
            cbxVehiculo.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IncidenciaCrearForm_Load(object sender, EventArgs e)
        {
            var taller = new TallerRepository().Consultar(0);
            var vehiculo = new VehiculoRepository().Consultar(0).Where(x => x.Mantenimiento == true).ToList();

            var tallerBindingSource = new BindingSource();
            tallerBindingSource.DataSource = taller;
            cbxTaller.DataSource = tallerBindingSource.DataSource;
            cbxTaller.DisplayMember = "Nombre";
            cbxTaller.ValueMember = "ID";

            var vehiculoBindingSource = new BindingSource();
            vehiculoBindingSource.DataSource = vehiculo;
            cbxVehiculo.DataSource = vehiculoBindingSource.DataSource;
            cbxVehiculo.DisplayMember = "Chasis";
            cbxVehiculo.ValueMember = "ID";

            dtpFechaEntrada.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrada.CustomFormat = "dd-MM-yyyy";
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
           string.IsNullOrWhiteSpace(cbxVehiculo.Text) || string.IsNullOrWhiteSpace(cbxTaller.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else if (dtpFechaEntrada.Value.Date > dtpFechaSalida.Value.Date) MessageBox.Show("¡Fechas Incorrectas!");
            else
            {
                Incidencia incidencia = new Incidencia()
                {
                    Descripcion = txtDescripcion.Text,
                    Fecha_Entrada = dtpFechaEntrada.Value.Date,
                    Fecha_Salida = dtpFechaSalida.Value.Date,
                    TallerID = int.Parse(cbxTaller.SelectedValue.ToString()),
                    VehiculoID = int.Parse(cbxVehiculo.SelectedValue.ToString()),
                };
                //string chasis = new VehiculoRepository().Consultar(incidencia.VehiculoID)[0].Chasis;
                var existencia = _incidenciaRepository.ExisteCrear(cbxVehiculo.Text);

                if (existencia.Any()) MessageBox.Show("¡Ya existe esa incidencia, favor de crear uno nuevo!");
                else
                {
                    try
                    {
                        _incidenciaRepository.Crear(incidencia);
                        MessageBox.Show("¡Incidencia creada exitosamente!");
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
