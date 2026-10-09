namespace PROYECTO_7_10_26
{
    partial class frmConsultaSala
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
            dgvSalas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            SuspendLayout();
            // 
            // dgvSalas
            // 
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.Location = new Point(12, 12);
            dgvSalas.Name = "dgvSalas";
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.Size = new Size(752, 255);
            dgvSalas.TabIndex = 0;
            // 
            // frmConsultaSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 288);
            Controls.Add(dgvSalas);
            Name = "frmConsultaSala";
            Text = "frmConsultaSala";
            Load += frmConsultaSala_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSalas;
    }
}