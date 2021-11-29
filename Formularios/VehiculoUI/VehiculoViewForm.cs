using ProyectoFinalPooJA.Datos.Entities;
using ProyectoFinalPooJA.Formularios.General;
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
    public partial class VehiculoViewForm : GeneralSearchForm
    {
        VehiculoRepository _vehiculoRepository;
        public static int ID = 0;
        public VehiculoViewForm()
        {
            InitializeComponent();
            _vehiculoRepository = new VehiculoRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            VehiculoCrearForm form = new VehiculoCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                VehiculoActualizarForm form = new VehiculoActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
        }

        private void VehiculoViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvVehiculo.ReadOnly = true;
        }
        public void Cargardgv()
        {
            _vehiculoRepository = new VehiculoRepository();
            var datos = _vehiculoRepository.ConsultarGenery(0, x => x.Modelo, x => x.Color, x=>x.Empleado, x=>x.Tipo_Vehiculo).ToList();
            dgvVehiculo.DataSource = MapeoVehiculo(datos);
            dgvVehiculo.Columns["ID"].Visible = false;
            dgvVehiculo.Columns["ColorID"].Visible = false;
            dgvVehiculo.Columns["EmpleadoID"].Visible = false;
            dgvVehiculo.Columns["ModeloID"].Visible = false;
            dgvVehiculo.Columns["Tipo_VehiculoID"].Visible = false;
            //dgvVehiculo.Columns["Mantenimiento"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Registro"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Modificacion"].Visible = false;
        }
        List<VehiculoView> MapeoVehiculo(List<Vehiculo> datos)
        {
            var lista = new List<VehiculoView>();
            foreach (var item in datos)
            {
                lista.Add(new VehiculoView
                {
                    ID = item.ID,
                    Anio = item.Anio,
                    Chasis = item.Chasis,
                    Color = item.Color.Nombre,
                    ColorID = item.ColorID,
                    Combustible = item.Combustible,
                    Empleado = item.Empleado.Nombre,
                    EmpleadoID = item.EmpleadoID,
                    Mantenimiento = item.Mantenimiento,
                    Modelo = item.Modelo.Nombre,
                    ModeloID = item.ModeloID,
                    Placa = item.Placa,
                    Tipo_Vehiculo = item.Tipo_Vehiculo.Nombre,
                    Tipo_VehiculoID= item.Tipo_VehiculoID,
                    Transmision= item.Transmision
                });
            }
            return lista;
        }

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvVehiculo.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Vehiculo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _vehiculoRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show("¡El campo es obligatorio!");
                Cargardgv();
            }
            else
            {
                var datos = _vehiculoRepository.Filtro(txtFiltro.Text.ToUpper());
                dgvVehiculo.DataSource = MapeoVehiculo(datos);
            }
        }
    }
}
