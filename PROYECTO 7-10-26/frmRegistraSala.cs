using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PROYECTO_7_10_26.Modelos;
using PROYECTO_7_10_26.Data;

namespace PROYECTO_7_10_26
{
    public partial class frmRegistraSala : Form
    {
        public frmRegistraSala()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosSalas datosSalas = new DatosSalas();
            Salas sala = new Salas
            {
                NombreSala = txtN.Text,
                capacidad = Convert.ToInt32(txtCap.Text)
            };
            datosSalas.GuardarSala(sala);

            limpiaCajasSalas();

            MessageBox.Show("Sala guardado correctamente.");


        }

        private void limpiaCajasSalas()
        {
            txtN.Text = string.Empty;
            txtCap.Text = string.Empty;
        }

        private void lblCapacidad_Click(object sender, EventArgs e)
        {

        }
    }
}
