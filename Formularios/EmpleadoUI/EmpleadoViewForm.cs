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

namespace ProyectoFinalPooJA.Formularios.EmpleadoUI
{
    public partial class EmpleadoViewForm : GeneralSearchForm
    {
        EmpleadoRepository _empleadoRepository;
        public static int ID = 0;
        public EmpleadoViewForm()
        {
            InitializeComponent();
            _empleadoRepository = new EmpleadoRepository();
        }

        private void EmpleadoViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }
        public void Cargardgv()
        {
            _empleadoRepository = new EmpleadoRepository();
            var datos = _empleadoRepository.ConsultarGenery(0,x=>x.Cargo, x=>x.Departamento).ToList();
            dgvEmpleado.DataSource = MapeoEmpleado(datos);
            dgvEmpleado.Columns["ID"].Visible = false;
            dgvEmpleado.Columns["CargoID"].Visible = false;
            dgvEmpleado.Columns["DepartamentoID"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Registro"].Visible = false;
            //dgvEmpleado.Columns["Fecha_Modificacion"].Visible = false;
        }
        List<EmpleadoView> MapeoEmpleado(List<Empleado> datos)
        {
            var lista = new List<EmpleadoView>();
            foreach (var item in datos)
            {
                lista.Add(new EmpleadoView
                {
                    ID = item.ID,
                    Nombre = item.Nombre,
                   Cargo  = item.Cargo.Nombre,
                    Cedula = item.Cedula,
                    Codigo_Empleado = item.Codigo_Empleado,
                    Correo = item.Correo,
                    Departameto = item.Departamento.Nombre,
                    Fecha_Ingreso = item.Fecha_Ingreso,
                    Fecha_Nacimiento = item.Fecha_Nacimiento,
                    Edad = item.Edad,
                    Telefono = item.Telefono
                });
            }
            return lista;
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
                var datos = _empleadoRepository.Filtro(txtFiltro.Text.ToUpper());
                dgvEmpleado.DataSource = MapeoEmpleado(datos);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            EmpleadoCrearForm form = new EmpleadoCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _empleadoRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvEmpleado.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID == 0) MessageBox.Show("¡No selecciono registro!");
            else
            {
                EmpleadoActualizarForm form = new EmpleadoActualizarForm();
                form.ShowDialog();
                Cargardgv();
            }
            ID = 0;
        }
    }
}
