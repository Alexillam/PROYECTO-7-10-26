namespace PROYECTO_7_10_26
{
    partial class frmRegistraSala
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
            lblCapacidad = new Label();
            btnGuardar = new Button();
            lblNombre = new Label();
            txtCap = new TextBox();
            txtN = new TextBox();
            SuspendLayout();
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(25, 113);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(83, 20);
            lblCapacidad.TabIndex = 5;
            lblCapacidad.Text = "Capacidad:";
            lblCapacidad.Click += lblCapacidad_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(154, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre Sala:";
            // 
            // txtCap
            // 
            txtCap.Location = new Point(25, 136);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(125, 27);
            txtCap.TabIndex = 11;
            // 
            // txtN
            // 
            txtN.Location = new Point(32, 68);
            txtN.Name = "txtN";
            txtN.Size = new Size(125, 27);
            txtN.TabIndex = 12;
            // 
            // frmRegistraSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 220);
            Controls.Add(txtN);
            Controls.Add(txtCap);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(lblCapacidad);
            Name = "frmRegistraSala";
            Text = "frmRegistraSala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblNombre;
        private Label label2;
        private Label lblCapacidad;
        private Button btnGuardar;
        private TextBox txtCap;
        private TextBox txtN;
    }
}