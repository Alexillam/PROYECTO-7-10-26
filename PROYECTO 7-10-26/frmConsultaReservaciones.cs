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
    public partial class frmConsultaReservaciones : Form
    {
        public frmConsultaReservaciones()
        {
            InitializeComponent();
        }

        private void frmConsultaReservaciones_Load(object sender, EventArgs e)
        {
            DatosReservacion datosReservaciones = new DatosReservacion();

            List<ReservacionesDTO> reservaciones = datosReservaciones.ObtenerReservaciones();

            dgvReservaciones.DataSource = reservaciones;
        }
    }
}
