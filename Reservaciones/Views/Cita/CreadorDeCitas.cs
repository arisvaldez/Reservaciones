using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pabo.Calendar;
using Reservaciones.DAO;
using Reservaciones.Models;
using Reservaciones.Utils;
using Reservaciones.Views.Cliente;
using Reservaciones.Views.Profesional;

namespace Reservaciones.Cita
{
    public partial class CreadorDeCitas : Form, IContract
    {
        private int IdProfesional = 0;
        private int IdCliente = 0;
        
        public CreadorDeCitas()
        {
            InitializeComponent();
            var item = new DateItem();
            item.Date = new DateTime(2020, 11, 25);
            item.Enabled = false;
            item.BackColor1 = Color.Red;

            DisponibilidadCalendar.AddDateInfo(item);
            DisponibilidadCalendar.SelectionMode = mcSelectionMode.One;

        

            CMBHora.Items.AddRange(ObtenerTodasLasHoras().ToArray());
        }

        private List<string> ObtenerTodasLasHoras()
        {
           return new List<string>() {
            "08:00 am",
            "08:30 am",
            "09:00 am",
            "09:30 am",
            "10:00 am",
            "10:30 am",
            "11:00 am",
            "11:30 am",
            "12:00 pm",
            "12:30 pm",
            "01:00 pm",
            "01:30 pm",
            "02:00 pm",
            "02:30 pm",
            "03:00 pm",
            "03:30 pm",
            "04:00 pm",
            };
        }

        public void Execute(IModel model)
        {

            if (model.Tipo == Tipos.CLIENTE)
            {
                var item = (ClienteModel)model;
                LblClienteNombre.Text = $"{item.Nombre} {item.Apellido}";
                LblClienteDocumento.Text = item.Documento;
            }

            else if (model.Tipo == Tipos.PROFESIONAL)
            {

                var item = (ProfesionalModel)model;
                IdProfesional = item.Id;
                LblProfesionalNombre.Text = $"{item.Nombre} {item.Apellido}";
                LblProfesion.Text = item.Profesion;
            }
        }

        private void BtnBuscarProfesional_Click(object sender, EventArgs e)
        {
            new FrmConsultarProfesional(this)
            {
                Visible = true
            };
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            new FrmConsultaCliente(this)
            {
                Visible = true
            };
        }

        private void DisponibilidadCalendar_DaySelected(object sender, DaySelectedEventArgs e)
        {
            string[] m_daysSelected = e.Days;
            UpdateComboHoras(Convert.ToInt32(Convert.ToDateTime(m_daysSelected[0].ToString()).DayOfWeek));
            
        }

        private void UpdateComboHoras(int dia) 
        {
            CMBHora.Items.Clear();
            CMBHora.Items.AddRange(ObtenerTodasLasHoras().ToArray());

            var horasDisponibles = new ProfesionalDAO().GetDisponibilidadProfesional(IdProfesional, dia);


            foreach (var item in horasDisponibles)
            {
                MessageBox.Show(" Id Dia "+item.IdDia.ToString());
                MessageBox.Show("Hora Inicio "+item.HoraInicio);
            }
        }
    }
}
