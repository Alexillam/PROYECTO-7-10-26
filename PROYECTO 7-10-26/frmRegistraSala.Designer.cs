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
            txtN = new TextBox();
            txtCap = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtCap).BeginInit();
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
            // txtN
            // 
            txtN.Location = new Point(25, 57);
            txtN.Name = "txtN";
            txtN.Size = new Size(125, 27);
            txtN.TabIndex = 12;
            // 
            // txtCap
            // 
            txtCap.Location = new Point(25, 137);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(46, 27);
            txtCap.TabIndex = 13;
            // 
            // frmRegistraSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 220);
            Controls.Add(txtCap);
            Controls.Add(txtN);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(lblCapacidad);
            Name = "frmRegistraSala";
            Text = "frmRegistraSala";
            ((System.ComponentModel.ISupportInitialize)txtCap).EndInit();
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
        private TextBox txtN;
        private NumericUpDown txtCap;
    }
}