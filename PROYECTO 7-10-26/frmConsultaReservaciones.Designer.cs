namespace PROYECTO_7_10_26
{
    partial class frmConsultaReservaciones
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
            dgvReservaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservaciones.Location = new Point(12, 12);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersWidth = 51;
            dgvReservaciones.Size = new Size(758, 264);
            dgvReservaciones.TabIndex = 0;
            // 
            // frmConsultaReservaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 300);
            Controls.Add(dgvReservaciones);
            Name = "frmConsultaReservaciones";
            Text = "frmConsultaReservaciones";
            Load += frmConsultaReservaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservaciones;
    }
}