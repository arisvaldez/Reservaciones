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
            this.components = new System.ComponentModel.Container();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnAgregarTelefono = new System.Windows.Forms.Button();
            this.BtnRemoverTelefono = new System.Windows.Forms.Button();
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.DgvTelefono = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TmrMensaje = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelefono)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.BtnRegistrar.Location = new System.Drawing.Point(54, 341);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnAgregarTelefono
            // 
            this.BtnAgregarTelefono.Location = new System.Drawing.Point(53, 248);
            this.BtnAgregarTelefono.Name = "BtnAgregarTelefono";
            this.BtnAgregarTelefono.Size = new System.Drawing.Size(61, 23);
            this.BtnAgregarTelefono.TabIndex = 9;
            this.BtnAgregarTelefono.Text = "Agregar";
            this.BtnAgregarTelefono.UseVisualStyleBackColor = true;
            this.BtnAgregarTelefono.Click += new System.EventHandler(this.BtnAgregarTelefono_Click);
            // 
            // BtnRemoverTelefono
            // 
            this.BtnRemoverTelefono.Location = new System.Drawing.Point(120, 248);
            this.BtnRemoverTelefono.Name = "BtnRemoverTelefono";
            this.BtnRemoverTelefono.Size = new System.Drawing.Size(61, 23);
            this.BtnRemoverTelefono.TabIndex = 10;
            this.BtnRemoverTelefono.Text = "Remover";
            this.BtnRemoverTelefono.UseVisualStyleBackColor = true;
            this.BtnRemoverTelefono.Click += new System.EventHandler(this.BtnRemoverTelefono_Click);
            // 
            // DGVCliente
            // 
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.Location = new System.Drawing.Point(12, 389);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCliente.Size = new System.Drawing.Size(887, 186);
            this.DGVCliente.TabIndex = 11;
            this.DGVCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCliente_CellClick);
            this.DGVCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCliente_CellDoubleClick);
            // 
            // DgvTelefono
            // 
            this.DgvTelefono.AllowUserToAddRows = false;
            this.DgvTelefono.AllowUserToDeleteRows = false;
            this.DgvTelefono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Numero});
            this.DgvTelefono.Location = new System.Drawing.Point(197, 169);
            this.DgvTelefono.Name = "DgvTelefono";
            this.DgvTelefono.ReadOnly = true;
            this.DgvTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTelefono.Size = new System.Drawing.Size(388, 150);
            this.DgvTelefono.TabIndex = 12;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(9, 9);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMensaje.Size = new System.Drawing.Size(35, 13);
            this.LblMensaje.TabIndex = 13;
            this.LblMensaje.Text = "label5";
            // 
            // TmrMensaje
            // 
            this.TmrMensaje.Interval = 2500;
            this.TmrMensaje.Tick += new System.EventHandler(this.panel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 28);
            this.panel1.TabIndex = 14;
            // 
            // CmbTipoTelefono
            // 
            this.CmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoTelefono.FormattingEnabled = true;
            this.CmbTipoTelefono.Items.AddRange(new object[] {
            "Residencial",
            "Celular"});
            this.CmbTipoTelefono.Location = new System.Drawing.Point(53, 169);
            this.CmbTipoTelefono.Name = "CmbTipoTelefono";
            this.CmbTipoTelefono.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoTelefono.TabIndex = 15;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(53, 209);
            this.TxtTelefono.Mask = "(999) 000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(135, 20);
            this.TxtTelefono.TabIndex = 16;
            this.TxtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numero";
            // 
            // FrmCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.CmbTipoTelefono);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvTelefono);
            this.Controls.Add(this.DGVCliente);
            this.Controls.Add(this.BtnRemoverTelefono);
            this.Controls.Add(this.BtnAgregarTelefono);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button BtnAgregarTelefono;
        private System.Windows.Forms.Button BtnRemoverTelefono;
        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.DataGridView DgvTelefono;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Timer TmrMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbTipoTelefono;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}