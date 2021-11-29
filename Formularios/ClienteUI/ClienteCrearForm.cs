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
    public partial class ClienteCrearForm : Form
    {
        ClienteRepository _clienteRepository;
        public ClienteCrearForm()
        {
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
            cbxTipo_Indentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cbxTipo_Indentificacion.Text)
                || string.IsNullOrWhiteSpace(txtIdentificacion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)
                || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                MessageBox.Show("¡Los campos son obligatorio!");
            else
            {

                var existencia = _clienteRepository.ExisteCrear(txtIdentificacion.Text.ToUpper());

                if (existencia.Any()) MessageBox.Show("¡Ya existe ese cliente, favor de crear uno nuevo!");
                else
                {

                    Cliente cliente = new Cliente()
                    {
                        Nombre = txtNombre.Text,
                        Correo = txtCorreo.Text,
                        Direccion = txtDireccion.Text,
                        Identificacion = txtIdentificacion.Text,
                        Telefono = txtTelefono.Text,
                        Tipo_Identificacion = cbxTipo_Indentificacion.Text
                    };
                    try
                    {
                        _clienteRepository.Crear(cliente);
                        MessageBox.Show("¡Cliente creado exitosamente!");
                        this.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
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
    }
}
