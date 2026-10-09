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
    public partial class frmConsultaSala : Form
    {
        public frmConsultaSala()
        {
            InitializeComponent();
        }

        private void frmConsultaSala_Load(object sender, EventArgs e)
        {
            DatosSalas datosSalas = new DatosSalas();
            List<Salas> salas = datosSalas.ObtenerSalas();

            dgvSalas.DataSource = salas;
        }
    }
}
