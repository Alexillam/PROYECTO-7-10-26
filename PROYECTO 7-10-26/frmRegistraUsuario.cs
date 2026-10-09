using PROYECTO_7_10_26.Data;
using PROYECTO_7_10_26.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_7_10_26
{
    public partial class frmRegistraUsuario : Form
    {
        public frmRegistraUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosUsuarios datosUsuarios = new DatosUsuarios();
            Usuarios usuario = new Usuarios
            {
                Nombre = txtNombre.Text,
                Departamento = txtDepartamento.Text,
                Telefono = txtTelefono.Text
            };

            datosUsuarios.GuardarUsuario(usuario);

            limpiaCajasUsuarios();

            MessageBox.Show("Usuario guardado correctamente.");

        }

        private void limpiaCajasUsuarios()
        {
            txtNombre.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}
