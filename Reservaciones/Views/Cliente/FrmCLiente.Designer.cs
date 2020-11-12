namespace Reservaciones.Views.Cliente
{
    partial class FrmCLiente
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.DgvTelefono = new System.Windows.Forms.DataGridView();
            this.TipoTelefono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(53, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(191, 93);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(466, 93);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroDocumento.TabIndex = 2;
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte"});
            this.CmbTipoDocumento.Location = new System.Drawing.Point(318, 93);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoDocumento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo De Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero De Documento";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(20, 429);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DGVCliente
            // 
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.Location = new System.Drawing.Point(12, 490);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.Size = new System.Drawing.Size(887, 186);
            this.DGVCliente.TabIndex = 11;
            // 
            // DgvTelefono
            // 
            this.DgvTelefono.AllowUserToDeleteRows = false;
            this.DgvTelefono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoTelefono,
            this.Numero});
            this.DgvTelefono.Location = new System.Drawing.Point(51, 185);
            this.DgvTelefono.Name = "DgvTelefono";
            this.DgvTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTelefono.Size = new System.Drawing.Size(348, 150);
            this.DgvTelefono.TabIndex = 12;
            // 
            // TipoTelefono
            // 
            this.TipoTelefono.HeaderText = "Tipo";
            this.TipoTelefono.Items.AddRange(new object[] {
            "Residencial",
            "Celular"});
            this.TipoTelefono.Name = "TipoTelefono";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // FrmCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 688);
            this.Controls.Add(this.DgvTelefono);
            this.Controls.Add(this.DGVCliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTipoDocumento);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Name = "FrmCLiente";
            this.Text = "FrmCLiente";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.ComboBox CmbTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.DataGridView DgvTelefono;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}