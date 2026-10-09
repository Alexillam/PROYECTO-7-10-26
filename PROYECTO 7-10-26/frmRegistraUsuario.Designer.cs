namespace PROYECTO_7_10_26
{
    partial class frmRegistraUsuario
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
            lblNombre = new Label();
            lblDepartamento = new Label();
            lblTelefono = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtDepartamento = new TextBox();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(23, 106);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(109, 20);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(23, 191);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(239, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(23, 145);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(147, 27);
            txtDepartamento.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(23, 214);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(147, 27);
            txtTelefono.TabIndex = 9;
            // 
            // frmRegistraUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 304);
            Controls.Add(txtTelefono);
            Controls.Add(txtDepartamento);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(lblTelefono);
            Controls.Add(lblDepartamento);
            Controls.Add(lblNombre);
            Name = "frmRegistraUsuario";
            Text = "frmRegistraUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDepartamento;
        private TextBox txtTelefono;
        private Label lblNombre;
        private Label lblDepartamento;
        private Label lblTelefono;
        private Button btnGuardar;
    }
}