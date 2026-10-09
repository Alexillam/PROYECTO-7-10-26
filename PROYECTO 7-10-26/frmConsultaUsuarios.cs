using PROYECTO_7_10_26.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PROYECTO_7_10_26.Modelos;

namespace PROYECTO_7_10_26
{
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            DatosUsuarios datosUsuarios = new DatosUsuarios();
            List<Usuarios> usuarios = datosUsuarios.ObtenerUsuarios();

            dgvUsuarios.DataSource = usuarios;
        }
    }
}
