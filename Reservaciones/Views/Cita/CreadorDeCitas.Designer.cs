namespace Reservaciones.Cita
{
    partial class CreadorDeCitas
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
            this.DisponibilidadCalendar = new Pabo.Calendar.MonthCalendar();
            this.BtnBuscarProfesional = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.CMBHora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblProfesionalNombre = new System.Windows.Forms.Label();
            this.LblProfesion = new System.Windows.Forms.Label();
            this.LblClienteDocumento = new System.Windows.Forms.Label();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisponibilidadCalendar
            // 
            this.DisponibilidadCalendar.ActiveMonth.Month = 11;
            this.DisponibilidadCalendar.ActiveMonth.Year = 2020;
            this.DisponibilidadCalendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.DisponibilidadCalendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DisponibilidadCalendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DisponibilidadCalendar.Header.TextColor = System.Drawing.Color.White;
            this.DisponibilidadCalendar.ImageList = null;
            this.DisponibilidadCalendar.Location = new System.Drawing.Point(12, 204);
            this.DisponibilidadCalendar.MaxDate = new System.DateTime(2030, 11, 23, 15, 32, 22, 514);
            this.DisponibilidadCalendar.MinDate = new System.DateTime(2010, 11, 23, 15, 32, 22, 514);
            this.DisponibilidadCalendar.Month.BackgroundImage = null;
            this.DisponibilidadCalendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Name = "DisponibilidadCalendar";
            this.DisponibilidadCalendar.Size = new System.Drawing.Size(217, 184);
            this.DisponibilidadCalendar.TabIndex = 1;
            this.DisponibilidadCalendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.DisponibilidadCalendar_DaySelected);
            // 
            // BtnBuscarProfesional
            // 
            this.BtnBuscarProfesional.Location = new System.Drawing.Point(74, 54);
            this.BtnBuscarProfesional.Name = "BtnBuscarProfesional";
            this.BtnBuscarProfesional.Size = new System.Drawing.Size(26, 28);
            this.BtnBuscarProfesional.TabIndex = 2;
            this.BtnBuscarProfesional.Text = "Q";
            this.BtnBuscarProfesional.UseVisualStyleBackColor = true;
            this.BtnBuscarProfesional.Click += new System.EventHandler(this.BtnBuscarProfesional_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(308, 54);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(27, 28);
            this.BtnCliente.TabIndex = 3;
            this.BtnCliente.Text = "Q";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // CMBHora
            // 
            this.CMBHora.FormattingEnabled = true;
            this.CMBHora.Location = new System.Drawing.Point(266, 216);
            this.CMBHora.Name = "CMBHora";
            this.CMBHora.Size = new System.Drawing.Size(121, 21);
            this.CMBHora.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profesional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // LblProfesionalNombre
            // 
            this.LblProfesionalNombre.AutoSize = true;
            this.LblProfesionalNombre.Location = new System.Drawing.Point(12, 88);
            this.LblProfesionalNombre.Name = "LblProfesionalNombre";
            this.LblProfesionalNombre.Size = new System.Drawing.Size(44, 13);
            this.LblProfesionalNombre.TabIndex = 8;
            this.LblProfesionalNombre.Text = "Nombre";
            // 
            // LblProfesion
            // 
            this.LblProfesion.AutoSize = true;
            this.LblProfesion.Location = new System.Drawing.Point(12, 113);
            this.LblProfesion.Name = "LblProfesion";
            this.LblProfesion.Size = new System.Drawing.Size(51, 13);
            this.LblProfesion.TabIndex = 9;
            this.LblProfesion.Text = "Profesion";
            // 
            // LblClienteDocumento
            // 
            this.LblClienteDocumento.AutoSize = true;
            this.LblClienteDocumento.Location = new System.Drawing.Point(263, 113);
            this.LblClienteDocumento.Name = "LblClienteDocumento";
            this.LblClienteDocumento.Size = new System.Drawing.Size(40, 13);
            this.LblClienteDocumento.TabIndex = 11;
            this.LblClienteDocumento.Text = "Cedula";
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Location = new System.Drawing.Point(263, 88);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(44, 13);
            this.LblClienteNombre.TabIndex = 10;
            this.LblClienteNombre.Text = "Nombre";
            // 
            // CreadorDeCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.LblClienteDocumento);
            this.Controls.Add(this.LblClienteNombre);
            this.Controls.Add(this.LblProfesion);
            this.Controls.Add(this.LblProfesionalNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBHora);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnBuscarProfesional);
            this.Controls.Add(this.DisponibilidadCalendar);
            this.Name = "CreadorDeCitas";
            this.Text = "CreadorDeCitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pabo.Calendar.MonthCalendar DisponibilidadCalendar;
        private System.Windows.Forms.Button BtnBuscarProfesional;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.ComboBox CMBHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblProfesionalNombre;
        private System.Windows.Forms.Label LblProfesion;
        private System.Windows.Forms.Label LblClienteDocumento;
        private System.Windows.Forms.Label LblClienteNombre;
    }
}