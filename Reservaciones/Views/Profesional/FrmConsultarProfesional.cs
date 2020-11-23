using Reservaciones.DAO;
using Reservaciones.Models;
using Reservaciones.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.Views.Profesional
{
    public partial class FrmConsultarProfesional : Form
    {
        DataTable data;
        private IContract _Contract;
        public FrmConsultarProfesional(IContract contract)
        {
            InitializeComponent();
            data = new ProfesionalDAO().Get().ToDataTable();
            DgvProfesionales.DataSource = data;
            this._Contract = contract;
            DgvProfesionales.Columns[0].Visible = false;
        }

        private void TxtFiltar_TextChanged(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = $"nombre LIKE '%{TxtFiltrar.Text}%' OR apellido LIKE '%{TxtFiltrar.Text}%' OR Cedula = {TxtFiltrar.Text}";
        }

        private void DgvProfesionales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_Contract != null)
            {
                _Contract.Execute(new ProfesionalModel()
                {

                    Id = Convert.ToInt32(DgvProfesionales.CurrentRow.Cells["Id"].Value),
                    Nombre = DgvProfesionales.CurrentRow.Cells["Nombre"].Value.ToString(),
                    Apellido = DgvProfesionales.CurrentRow.Cells["Apellido"].Value.ToString(),
                    Profesion = "Profesional" //DgvProfesionales.CurrentRow.Cells["Profesion"].Value.ToString()
                });
                Close();
            }
        }
    }
}
