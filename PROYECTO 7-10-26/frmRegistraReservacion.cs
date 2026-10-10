using PROYECTO_7_10_26.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PROYECTO_7_10_26.Data;
using PROYECTO_7_10_26.Modelos;

namespace PROYECTO_7_10_26
{
    public partial class frmRegistraReservacion : Form
    {
        public frmRegistraReservacion()
        {
            InitializeComponent();
        }

        private void frmRegistraReservacion_Load(object sender, EventArgs e)
        {
            DatosSalas objDatosSala = new DatosSalas();
            DatosUsuarios objDatosUsuarios = new DatosUsuarios();

            List<Salas> listaSalas = objDatosSala.ObtenerSalas();
            List<Usuarios> listaUsuarios = objDatosUsuarios.ObtenerUsuarios();

            cbdSalas.DataSource = listaSalas;
            cbdSalas.DisplayMember = "NombreSala";
            cbdSalas.ValueMember = "Id";

            cbdUsuarios.DataSource = listaUsuarios;
            cbdUsuarios.DisplayMember = "Nombre";
            cbdUsuarios.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Reservaciones reservacion = new Reservaciones
            {
                IdSala = (int)cbdSalas.SelectedValue,
                IdUsuario = (int)cbdUsuarios.SelectedValue,
                Fecha = Fecha.Value
            };

            DatosReservacion datosReservaciones = new DatosReservacion();
            datosReservaciones.GuardarReservacion(reservacion);
        }
    }
}
