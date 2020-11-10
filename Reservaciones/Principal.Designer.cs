namespace Reservaciones
{
    partial class Principal
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
            this.MSPrincipal = new System.Windows.Forms.MenuStrip();
            this.MSPSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MSExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MPAdministar = new System.Windows.Forms.ToolStripMenuItem();
            this.MAProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.MAVisitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCita = new System.Windows.Forms.ToolStripMenuItem();
            this.MCReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.MCConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSPrincipal
            // 
            this.MSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSPSystem,
            this.MPAdministar,
            this.MPCita,
            this.reportesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MSPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MSPrincipal.Name = "MSPrincipal";
            this.MSPrincipal.Size = new System.Drawing.Size(1041, 24);
            this.MSPrincipal.TabIndex = 1;
            this.MSPrincipal.Text = "menuStrip1";
            // 
            // MSPSystem
            // 
            this.MSPSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSLogout,
            this.MSExit});
            this.MSPSystem.Name = "MSPSystem";
            this.MSPSystem.Size = new System.Drawing.Size(57, 20);
            this.MSPSystem.Text = "System";
            // 
            // MSLogout
            // 
            this.MSLogout.Name = "MSLogout";
            this.MSLogout.Size = new System.Drawing.Size(180, 22);
            this.MSLogout.Text = "Logout";
            // 
            // MSExit
            // 
            this.MSExit.Name = "MSExit";
            this.MSExit.Size = new System.Drawing.Size(180, 22);
            this.MSExit.Text = "Exit";
            // 
            // MPAdministar
            // 
            this.MPAdministar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAProfesional,
            this.MAVisitantes});
            this.MPAdministar.Name = "MPAdministar";
            this.MPAdministar.Size = new System.Drawing.Size(81, 20);
            this.MPAdministar.Text = "Administrar";
            // 
            // MAProfesional
            // 
            this.MAProfesional.Name = "MAProfesional";
            this.MAProfesional.Size = new System.Drawing.Size(180, 22);
            this.MAProfesional.Text = "Profesional";
            // 
            // MAVisitantes
            // 
            this.MAVisitantes.Name = "MAVisitantes";
            this.MAVisitantes.Size = new System.Drawing.Size(180, 22);
            this.MAVisitantes.Text = "Visitantes";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MPCita
            // 
            this.MPCita.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCReservas,
            this.MCConsultar});
            this.MPCita.Name = "MPCita";
            this.MPCita.Size = new System.Drawing.Size(40, 20);
            this.MPCita.Text = "Cita";
            // 
            // MCReservas
            // 
            this.MCReservas.Name = "MCReservas";
            this.MCReservas.Size = new System.Drawing.Size(180, 22);
            this.MCReservas.Text = "Reservar";
            // 
            // MCConsultar
            // 
            this.MCConsultar.Name = "MCConsultar";
            this.MCConsultar.Size = new System.Drawing.Size(180, 22);
            this.MCConsultar.Text = "Consultar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmadasToolStripMenuItem,
            this.canceladasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // confirmadasToolStripMenuItem
            // 
            this.confirmadasToolStripMenuItem.Name = "confirmadasToolStripMenuItem";
            this.confirmadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.confirmadasToolStripMenuItem.Text = "Completadas";
            // 
            // canceladasToolStripMenuItem
            // 
            this.canceladasToolStripMenuItem.Name = "canceladasToolStripMenuItem";
            this.canceladasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.canceladasToolStripMenuItem.Text = "Canceladas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 583);
            this.Controls.Add(this.MSPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MSPrincipal.ResumeLayout(false);
            this.MSPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MSPSystem;
        private System.Windows.Forms.ToolStripMenuItem MSLogout;
        private System.Windows.Forms.ToolStripMenuItem MSExit;
        private System.Windows.Forms.ToolStripMenuItem MPAdministar;
        private System.Windows.Forms.ToolStripMenuItem MAProfesional;
        private System.Windows.Forms.ToolStripMenuItem MAVisitantes;
        private System.Windows.Forms.ToolStripMenuItem MPCita;
        private System.Windows.Forms.ToolStripMenuItem MCReservas;
        private System.Windows.Forms.ToolStripMenuItem MCConsultar;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

