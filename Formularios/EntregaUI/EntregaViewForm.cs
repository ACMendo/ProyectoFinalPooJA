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

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public partial class EntregaViewForm : GeneralSearchForm
    {
        EntregaRepository _entregaRepository;
        public static int ID = 0;
        public EntregaViewForm()
        {
            InitializeComponent();
            _entregaRepository = new EntregaRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            EntregaCrearForm form = new EntregaCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                EntregaActualizarForm form = new EntregaActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
            ID = 0;
        }

        private void dgvEntrega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvEntrega.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void EntregaViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }
        public void Cargardgv()
        {
            _entregaRepository = new EntregaRepository();
            var datos = _entregaRepository.ConsultarGenery(0, x => x.Prioridad, x => x.Cliente, x => x.Empleado).ToList();
            dgvEntrega.DataSource = MapeoEntrega(datos);
            dgvEntrega.Columns["ID"].Visible = false;
            dgvEntrega.Columns["ClienteID"].Visible = false;
            dgvEntrega.Columns["EmpleadoID"].Visible = false;
            dgvEntrega.Columns["PrioridadID"].Visible = false;
            //dgvVehiculo.Columns["Mantenimiento"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Registro"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Modificacion"].Visible = false;
        }
        List<EntregaView> MapeoEntrega(List<Entrega> datos)
        {
            var lista = new List<EntregaView>();
            foreach (var item in datos)
            {
                lista.Add(new EntregaView
                {
                    ID = item.ID,
                    Cliente = item.Cliente.Nombre,
                    ClienteID = item.ClienteID,
                    Descripcion = item.Descripcion,
                    Destino = item.Destino,
                    Fecha_Regreso = item.Fecha_Regreso,
                    Empleado = item.Empleado.Nombre,
                    EmpleadoID = item.EmpleadoID,
                    Fecha_Salida = item.Fecha_Salida,
                    Peso = item.Peso,
                    Prioridad = item.Prioridad.Nombre,
                    PrioridadID = item.PrioridadID
                });
            }
            return lista;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Entrega", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _entregaRepository.Borrar(ID);
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
                var datos = _entregaRepository.Filtro(txtFiltro.Text.ToUpper());
                dgvEntrega.DataSource = MapeoEntrega(datos);
            }
        }
    }
}
