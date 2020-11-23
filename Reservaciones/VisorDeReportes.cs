using Microsoft.Reporting.WinForms;
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

namespace Reservaciones
{
    public partial class VisorDeReportes : Form
    {
        DataTable dtCliente;
        ClienteDAO clienteDAO;
        public VisorDeReportes()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            dtCliente = clienteDAO.GetClientes().ToDataTable();
            Setup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void Setup()
        {
            List<TelefonoClienteModel> tlcliente = clienteDAO.GetTelefonoClientes(6);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reservaciones.ClienteReporte.rdlc";
            ReportDataSource data = new ReportDataSource("DatosCliente", dtCliente);
            ReportDataSource data2 = new ReportDataSource("TelefonoCliente", tlcliente);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(data);
            this.reportViewer1.LocalReport.DataSources.Add(data2);
            this.reportViewer1.RefreshReport();

        }
    }
}
