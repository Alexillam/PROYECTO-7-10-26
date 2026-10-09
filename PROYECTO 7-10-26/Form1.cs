namespace PROYECTO_7_10_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistraUsuario objfrmRegistrarUsuario = new frmRegistraUsuario();
            objfrmRegistrarUsuario.ShowDialog();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistraSala objfrmRegistrarSala = new frmRegistraSala();

            objfrmRegistrarSala.ShowDialog();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegistraReservacion objfrmRegistrarReservacion = new frmRegistraReservacion();

            objfrmRegistrarReservacion.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios objfrmConsultaUsuarios = new frmConsultaUsuarios();

            objfrmConsultaUsuarios.ShowDialog();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSala objfrmConsultaSalas = new frmConsultaSala();
            objfrmConsultaSalas.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistraReservacion objfrmConsultaReservacion = new frmRegistraReservacion();

            objfrmConsultaReservacion.ShowDialog();
        }
    }
}
