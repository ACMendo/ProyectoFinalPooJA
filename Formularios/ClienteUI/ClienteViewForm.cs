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

namespace ProyectoFinalPooJA.Formularios.ClienteUI
{
    public partial class ClienteViewForm : GeneralSearchForm
    {
        private ClienteRepository _clienteRepository;
        public static int ID = 0;
        public ClienteViewForm()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ClienteCrearForm form = new ClienteCrearForm();
            form.ShowDialog();
            Cargardgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ClienteViewForm.ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                ClienteActualizarForm form = new ClienteActualizarForm();
                form.ShowDialog();
                Cargardgv();
                ID = 0;
            }         
        }

        public void Cargardgv()
        {
            _clienteRepository = new ClienteRepository();
            dgvCliente.DataSource = _clienteRepository.Consultar(0);
            dgvCliente.Columns["ID"].Visible = false;
            dgvCliente.Columns["Borrado"].Visible = false;
            dgvCliente.Columns["Estatus"].Visible = false;
            dgvCliente.Columns["Fecha_Registro"].Visible = false;
            dgvCliente.Columns["Fecha_Modificacion"].Visible = false;
        }

        private void ClienteViewForm_Load(object sender, EventArgs e)
        {
            Cargardgv();
            dgvCliente.ReadOnly = true;
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
                dgvCliente.DataSource = _clienteRepository.Filtro(txtFiltro.Text.ToUpper());
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvCliente.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ClienteViewForm.ID == 0)
            {
                MessageBox.Show("¡No selecciono registro!");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de Borrar?", "Borrar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var resultado = _clienteRepository.Borrar(ID);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) Cargardgv();
                }
                ID = 0;
            }
        }
    }
}
