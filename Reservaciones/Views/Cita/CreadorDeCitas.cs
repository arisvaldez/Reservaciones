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

        private DateItem[] dateItems;

        private ProfesionalDAO profesionalDAO = new ProfesionalDAO();
        private CitaDAO citaDAO = new CitaDAO();
        public CreadorDeCitas()
        {
            InitializeComponent();

            

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
                IdCliente = Convert.ToInt32(item.Id);
            }

            else if (model.Tipo == Tipos.PROFESIONAL)
            {

                var item = (ProfesionalModel)model;
                IdProfesional = item.Id;
                LblProfesionalNombre.Text = $"{item.Nombre} {item.Apellido}";
                LblProfesion.Text = item.Profesion;

                dateItems = new DateItem[366];
                
                var diasDisponibles = profesionalDAO.GetDisponibilidadProfesional(IdProfesional);

                DiasNoLaborables();
                
                foreach (var itemDay in diasDisponibles)
                {
                    DiasLaborables(itemDay.IdDia);
                }
                
                DisponibilidadCalendar.AddDateInfo(dateItems);
                DisponibilidadCalendar.Refresh();
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
            var fechaSeleccionadaDisponinilidad = citaDAO.GetDisponibilidadProfesionalPorFecha(IdProfesional, m_daysSelected[0]);
            UpdateComboHoras(fechaSeleccionadaDisponinilidad);
            LblFechaCita.Text = m_daysSelected[0];
        }

        private void UpdateComboHoras(List<CitaModel> DiasAgendados) 
        {
            CMBHora.Items.Clear();
            var horas = ObtenerTodasLasHoras();
            var lista = new List<string>();

            foreach (var item in DiasAgendados)
            {
                lista.Add(item.Hora);
            }

            var horasTemp = horas.Except(lista).ToList();

            CMBHora.Items.AddRange(horasTemp.ToArray());
        }

        private void DiasNoLaborables()
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var di = new DateItem();
                di.Date = dt.AddDays(i);
                di.Enabled = false;
                dateItems[i] = di;

            }
        }

        private void RemoverCALendarioFormato()
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var di = new DateItem();
                di.Date = dt.AddDays(i);
                di.Enabled = false;
                dateItems[i] = di;

            }
        }

        private void DiasLaborables(int dia)
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var d = dt.AddDays(i);
                if (dateItems[i].Date == d)
                {
                    if (d.DayOfWeek == (DayOfWeek)dia)
                    {
                        var di = new DateItem();
                        di.Date = d;
                        di.BackColor1 = Color.Green;
                        dateItems[i] = di;
                    }
                }
            }
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {

            if (DisponibilidadCalendar.SelectedDates.Count == 0)
            {
                MessageBox.Show("Selecciona una fecha");
                return;
            }
            var result = citaDAO.Insert(new CitaModel()
            {
                IdCliente = this.IdCliente,
                IdProfesional = this.IdProfesional,
                IdDia = Convert.ToInt32(DisponibilidadCalendar.SelectedDates[0].DayOfWeek),
                Hora = CMBHora.SelectedItem.ToString(),
                FechaCita = DisponibilidadCalendar.SelectedDates[0].ToShortDateString()
            });

            if(result)
                MessageBox.Show("Cita Generada Correctamente");
            else
                MessageBox.Show("Ocurrio un error inesperado");
        }
    }
}
