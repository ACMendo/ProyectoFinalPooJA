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

namespace ProyectoFinalPooJA.Formularios.ReportesUI
{
    public partial class ReporteEntregas : Form
    {
        EntregaRepository _entregaRepository;
        static List<Entrega> entregas = new List<Entrega>();
        public ReporteEntregas()
        {
            InitializeComponent();
            //_entregaRepository = new EntregaRepository();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReporteEntregas_Load(object sender, EventArgs e)
        {
            Consulta();
            dgvEntregasReport.ReadOnly = true;
        }

        void  Consulta()
        {
            _entregaRepository = new EntregaRepository();
            var datos = _entregaRepository.ConsultarGenery(0, x => x.Cliente, x => x.Empleado, x => x.Prioridad).ToList();
            entregas = datos;
            dgvEntregasReport.DataSource = MapeoReporte(datos);
            //dgvEntregasReport.Columns["ID"].Visible = false;
            //dgvEntregasReport.Columns["Borrado"].Visible = false;
            //dgvEntregasReport.Columns["Estatus"].Visible = false;
            //dgvEntregasReport.Columns["Fecha_Registro"].Visible = false;
            //dgvEntregasReport.Columns["Fecha_Modificacion"].Visible = false;            
            lblTotalRegistros.Text = entregas.Count().ToString();
        }
        List<ReporteView> MapeoReporte(List<Entrega> datos)
        {
            var lista = new List<ReporteView>();
            foreach (var item in datos)
            {
                lista.Add(new ReporteView
                {
                    Cliente = item.Cliente.Nombre,
                    Descripcion = item.Descripcion,
                    Destino = item.Destino,
                    Fecha_Regreso = item.Fecha_Regreso,
                    Empleado = item.Empleado.Nombre,
                    Fecha_Salida = item.Fecha_Salida,
                    Peso = item.Peso.ToString(),
                    Prioridad = item.Prioridad.Nombre
                });
            }
            return lista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarDatosReporte_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void btnExcelData_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = $"d:\\Reporte Entregas -{ DateTime.Now: dd-MM-yyyy_hhmmss tt}.xlsx";
                new Reports().GenerateExcelEntregas(entregas, nombreArchivo);
                MessageBox.Show("Excel Generado en la ruta:  d:\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando excel, Error: " + ex.Message);
            }
        }
    }
}
