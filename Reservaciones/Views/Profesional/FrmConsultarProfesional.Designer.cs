namespace Reservaciones.Views.Profesional
{
    partial class FrmConsultarProfesional
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.DgvProfesionales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profesionales";
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Location = new System.Drawing.Point(12, 79);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(776, 20);
            this.TxtFiltrar.TabIndex = 4;
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltar_TextChanged);
            // 
            // DgvProfesionales
            // 
            this.DgvProfesionales.AllowUserToAddRows = false;
            this.DgvProfesionales.AllowUserToDeleteRows = false;
            this.DgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesionales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvProfesionales.Location = new System.Drawing.Point(12, 105);
            this.DgvProfesionales.Name = "DgvProfesionales";
            this.DgvProfesionales.ReadOnly = true;
            this.DgvProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProfesionales.Size = new System.Drawing.Size(776, 404);
            this.DgvProfesionales.TabIndex = 3;
            this.DgvProfesionales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesionales_CellDoubleClick);
            // 
            // FrmConsultarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFiltrar);
            this.Controls.Add(this.DgvProfesionales);
            this.Name = "FrmConsultarProfesional";
            this.Text = "FrmConsultarProfesional";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltrar;
        private System.Windows.Forms.DataGridView DgvProfesionales;
    }
}