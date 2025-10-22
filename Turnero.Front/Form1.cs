using Turnero.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Turnero.Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Turno turn = new Turno();

            turn.NumeroTurno = int.Parse(txtTurno.Text);
            turn.Paciente = txtPac.Text;
            turn.Doctor = txtDoc.Text;
            turn.Fecha = dtpTurno.Value.Date;
            turn.Hora = timePicker.Value;
            DateTime fechaHoraFinal = turn.Fecha.AddHours(turn.Hora.Hour).AddMinutes(turn.Hora.Minute);

            turn.Fecha = fechaHoraFinal;

            lblSalida.Text = lblSalida.Text + "\r\n" + turn.Descripcion();

        }
    }
}
