using Reservaciones.DAO;
using Reservaciones.Models;
using Reservaciones.Utils;
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
    public partial class FrmConsultaCliente : Form
    {
        DataTable data;
        private  IContract _Contract;
        public FrmConsultaCliente(IContract Contract)
        {
            InitializeComponent();
            data = new ClienteDAO().GetClientes().ToDataTable();
            DgvClientes.DataSource = data;
            this._Contract = Contract;
            
            DgvClientes.Columns[0].Visible = false;
        }

        private void TxtFiltar_TextChanged(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = $"nombre LIKE '%{TxtFiltrar.Text}%' OR apellido LIKE '%{TxtFiltrar.Text}%' OR Documento = {TxtFiltrar.Text}";
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_Contract != null) 
            {
                _Contract.Execute(new ClienteModel() {

                    Id = Convert.ToInt32(DgvClientes.CurrentRow.Cells["Id"].Value),
                    Nombre = DgvClientes.CurrentRow.Cells["Nombre"].Value.ToString(),
                    Apellido = DgvClientes.CurrentRow.Cells["Apellido"].Value.ToString(),
                    Documento = DgvClientes.CurrentRow.Cells["Documento"].Value.ToString()
                }) ;
                Close();
            }

        }
    }
}
