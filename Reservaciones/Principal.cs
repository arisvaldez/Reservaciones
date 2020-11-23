using Reservaciones.Cita;
using Reservaciones.Views.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservaciones
{
    public partial class Principal : Form
    {
        Models.ClienteModel cliente = new Models.ClienteModel();
        public Principal()
        {
            InitializeComponent();
        }

        private void MAProfesional_Click(object sender, EventArgs e)
        {
            new Form() { 
                MdiParent = this,
                WindowState = FormWindowState.Maximized,
                Visible = true
            };
        }

        private void probarDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var cn = ConexionDB.GetMysqlConnection();
            string query = "Select * from titulos";
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, cn);

            var result = cmd.ExecuteReader();

            while (result.Read())
            {
                var libro = $"Titulo {result["titulo"]}";
                MessageBox.Show(libro);
            }

            cn.Close();
        }

        private void MAVisitantes_Click(object sender, EventArgs e)
        {
            new FrmCLiente().Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VisorDeReportes() { 
            MdiParent = this,
            Visible = true
            };
        }

        private void MCReservas_Click(object sender, EventArgs e)
        {
            new CreadorDeCitas() {
            MdiParent = this,
            
            Visible = true
            };
        }
    }
}
