namespace PROYECTO_7_10_26
{
    partial class frmRegistraReservacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbdSalas = new ComboBox();
            Fecha = new DateTimePicker();
            lblUsuario = new Label();
            lblSalas = new Label();
            lblFecha = new Label();
            btnGuardar = new Button();
            cbdUsuarios = new ComboBox();
            SuspendLayout();
            // 
            // cbdSalas
            // 
            cbdSalas.FormattingEnabled = true;
            cbdSalas.Location = new Point(24, 95);
            cbdSalas.Name = "cbdSalas";
            cbdSalas.Size = new Size(151, 28);
            cbdSalas.TabIndex = 1;
            // 
            // Fecha
            // 
            Fecha.Location = new Point(24, 157);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(250, 27);
            Fecha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(23, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuarios:";
            // 
            // lblSalas
            // 
            lblSalas.AutoSize = true;
            lblSalas.Location = new Point(30, 72);
            lblSalas.Name = "lblSalas";
            lblSalas.Size = new Size(46, 20);
            lblSalas.TabIndex = 4;
            lblSalas.Text = "Salas:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(19, 134);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(150, 20);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha de reservación:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(247, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(71, 32);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbdUsuarios
            // 
            cbdUsuarios.FormattingEnabled = true;
            cbdUsuarios.Location = new Point(24, 32);
            cbdUsuarios.Name = "cbdUsuarios";
            cbdUsuarios.Size = new Size(151, 28);
            cbdUsuarios.TabIndex = 7;
            // 
            // frmRegistraReservacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 232);
            Controls.Add(cbdUsuarios);
            Controls.Add(btnGuardar);
            Controls.Add(lblFecha);
            Controls.Add(lblSalas);
            Controls.Add(lblUsuario);
            Controls.Add(Fecha);
            Controls.Add(cbdSalas);
            Name = "frmRegistraReservacion";
            Text = "frmRegistraReservacion";
            Load += frmRegistraReservacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuarios;
        private ComboBox cbdSalas;
        private DateTimePicker Fecha;
        private Label lblUsuario;
        private Label lblSalas;
        private Label lblFecha;
        private Button btnGuardar;
        private ComboBox cbdUsuarios;
    }
}