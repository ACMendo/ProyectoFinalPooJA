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

namespace ProyectoFinalPooJA.Formularios.ClienteUI
{
    public partial class ClienteActualizarForm : Form
    {
        ClienteRepository _clienteRepository;
        public ClienteActualizarForm()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtIdentificacion.Clear();
            txtDireccion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteActualizarForm_Load(object sender, EventArgs e)
        {
            var cliente = _clienteRepository.Consultar(ClienteViewForm.ID)[0];
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            txtIdentificacion.Text = cliente.Identificacion;
            cbxTipo_Indentificacion.Text = cliente.Tipo_Identificacion;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cbxTipo_Indentificacion.Text)
               || string.IsNullOrWhiteSpace(txtIdentificacion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)
               || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                MessageBox.Show("¡Los campos son obligatorio!");
            else
            {
                var existencia = _clienteRepository.ExisteEditar(txtIdentificacion.Text.ToUpper(), ClienteViewForm.ID);
                if (existencia.Any()) MessageBox.Show("¡Ya existe otro cliente con estos datos, favor de crear uno nuevo!");

                else
                {
                    var cliente = _clienteRepository.Consultar(ClienteViewForm.ID)[0];
                    cliente.Nombre = txtNombre.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Identificacion = txtIdentificacion.Text;
                    cliente.Telefono = txtIdentificacion.Text;
                    cliente.Tipo_Identificacion = cbxTipo_Indentificacion.Text;

                    var resultado = _clienteRepository.Actualizar(cliente);
                    MessageBox.Show(resultado.Message);
                    if (resultado.Success) this.Close();

                }
            }
        }
    }
}
