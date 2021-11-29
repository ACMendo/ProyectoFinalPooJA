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
    public partial class IncidenciaActualizarForm : Form
    {
        IncidenciaRepository _incidenciaRepository;
        public IncidenciaActualizarForm()
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

        private void IncidenciaActualizarForm_Load(object sender, EventArgs e)
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

            var datos = _incidenciaRepository.Consultar(IncidenciaViewForm.ID)[0];
            txtDescripcion.Text = datos.Descripcion;
            cbxTaller.SelectedValue = datos.TallerID;
            cbxVehiculo.SelectedValue = datos.VehiculoID;
            dtpFechaEntrada.Value = datos.Fecha_Entrada;
            dtpFechaSalida.Value = datos.Fecha_Salida;

            dtpFechaEntrada.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrada.CustomFormat = "dd-MM-yyyy";
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.CustomFormat = "dd-MM-yyyy";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
         string.IsNullOrWhiteSpace(cbxVehiculo.Text) || string.IsNullOrWhiteSpace(cbxTaller.Text))
                MessageBox.Show("¡El campo es obligatorio!");
            else if (dtpFechaEntrada.Value.Date > dtpFechaSalida.Value.Date) MessageBox.Show("¡Fechas Incorrectas!");
            else
            {
                
                //string chasis = new VehiculoRepository().Consultar(incidencia.VehiculoID)[0].Chasis;
                var existencia = _incidenciaRepository.ExisteEditar(cbxVehiculo.Text, IncidenciaViewForm.ID);

                if (existencia.Any()) MessageBox.Show("¡Ya existe esa incidencia, favor de crear uno nuevo!");
                else
                {
                    var incidencia = _incidenciaRepository.Consultar(IncidenciaViewForm.ID)[0];
                    incidencia.Descripcion = txtDescripcion.Text;
                    incidencia.Fecha_Entrada = dtpFechaEntrada.Value.Date;
                    incidencia.Fecha_Salida = dtpFechaSalida.Value.Date;
                    incidencia.TallerID = int.Parse(cbxTaller.SelectedValue.ToString());
                    incidencia.VehiculoID = int.Parse(cbxVehiculo.SelectedValue.ToString());
                    var resultado = _incidenciaRepository.Actualizar(incidencia);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();
                }
            }
        }
    }
}
