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

namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    public partial class IncidenciaViewForm : GeneralSearchForm
    {
        IncidenciaRepository _incidenciaRepository;
        public static int ID = 0;
        public IncidenciaViewForm()
        {
            InitializeComponent();
            _incidenciaRepository = new IncidenciaRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            IncidenciaCrearForm form = new IncidenciaCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                IncidenciaActualizarForm form = new IncidenciaActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
            ID = 0;
        }

        private void IncidenciaViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }
        public void Cargardgv()
        {
            _incidenciaRepository = new IncidenciaRepository();
            var datos = _incidenciaRepository.ConsultarGenery(0, x => x.Taller, x => x.Vehiculo).ToList();
            dgvIncidencia.DataSource = MapeoVehiculo(datos);
            dgvIncidencia.Columns["ID"].Visible = false;
            dgvIncidencia.Columns["TallerID"].Visible = false;
            dgvIncidencia.Columns["VehiculoID"].Visible = false;
        }
        List<InicidenciaView> MapeoVehiculo(List<Incidencia> datos)
        {
            var lista = new List<InicidenciaView>();
            foreach (var item in datos)
            {
                lista.Add(new InicidenciaView
                {
                    ID = item.ID,
                    Descripcion = item.Descripcion,
                    Chasis = item.Vehiculo.Chasis,
                    Fecha_Entrada = item.Fecha_Entrada,
                    Fecha_Salida = item.Fecha_Salida,
                    Taller = item.Taller.Nombre,
                    Placa = item.Vehiculo.Placa,
                    TallerID = item.TallerID,
                    VehiculoID = item.VehiculoID
                });
            }
            return lista;
        }

        private void dgvIncidencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvIncidencia.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Inicidencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _incidenciaRepository.Borrar(ID);
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
                var datos = _incidenciaRepository.Filtro(txtFiltro.Text.ToUpper());
                dgvIncidencia.DataSource = MapeoVehiculo(datos);
            }
        }
    }
}
