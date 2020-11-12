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

        public FrmCLiente()
        {
            InitializeComponent();
            var data = clienteDAO.GetClientes();
            DGVCliente.DataSource = data;
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
            if (clienteDAO.ExecuteNonQuery2(modelo)) 
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Falló");
            }
        }
    }
}
