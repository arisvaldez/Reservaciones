using Reservaciones.DAO;
using Reservaciones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.Views.Cliente
{
    public partial class FrmCLiente : Form
    {
        ClienteDAO clienteDAO = new ClienteDAO();
        DataTable ClienteData, TelefonoData;
        public FrmCLiente()
        {
            InitializeComponent();
            panel1.Hide();
            ClienteData = clienteDAO.GetClientes().ToDataTable();
            DGVCliente.DataSource = ClienteData;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ClienteModel modelo = new ClienteModel();
            modelo.Nombre = TxtNombre.Text;
            modelo.Apellido = TxtNombre.Text;
            modelo.TipoDocumento = CmbTipoDocumento.SelectedItem.ToString();
            modelo.Documento = TxtNumeroDocumento.Text;
           
            modelo.Telefonos = new List<TelefonoClienteModel>();

            foreach (DataGridViewRow item in DgvTelefono.Rows)
            {
                if (item.Cells[0].Value == null)
                    continue;

                var telefono = new TelefonoClienteModel();
                telefono.Tipo = item.Cells[0].Value.ToString();
                telefono.Numero = item.Cells[1].Value.ToString();
                modelo.Telefonos.Add(telefono);
            }

            if (clienteDAO.Insert(modelo)) 
            {
                LblMensaje.Text = "Se insertó correctamente";
                panel1.Show();
                panel1.BackColor = Color.Green;
                TmrMensaje.Start();
            }
            else
            {

                LblMensaje.Text = "Ocurrio un error, intente mas tarde";
                panel1.Show();
                panel1.BackColor = Color.Red;
                TmrMensaje.Start();
            }
        }

        private void TmrMensaje_Tick(object sender, EventArgs e)
        {
            panel1.Hide();
            TmrMensaje.Stop();
        }

        private void panel(object sender, EventArgs e)
        {

        }

        private void BtnAgregarTelefono_Click(object sender, EventArgs e)
        {
            DgvTelefono.Rows.Add(new []{CmbTipoTelefono.SelectedItem,TxtTelefono.Text});
        }

        private void BtnRemoverTelefono_Click(object sender, EventArgs e)
        {
            if (DgvTelefono.CurrentRow == null)
            {
                return;
            }

            DgvTelefono.Rows.RemoveAt(DgvTelefono.CurrentRow.Index);
        }

        private void DGVCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddDay_Click(object sender, EventArgs e)
        {
         
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
          
        }

        private void DGVCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  TelefonoData = 
        }
    }
}
