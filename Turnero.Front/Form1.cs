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
using System.Xml.Serialization;
using System.IO;

namespace Turnero.Front
{
    public partial class Form1 : Form
    {
        List<Turno> listaTurnos = new List<Turno>();
        string rutaArchivo = "turnos.xml";
        public Form1()
        {
            InitializeComponent();
           CargarTurnos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            turno.NumeroTurno = int.Parse(txtTurno.Text);
            turno.Paciente = txtPac.Text;
            turno.Doctor = txtDoc.Text;
            turno.Fecha = dtpTurno.Value.Date;
            turno.Hora = timePicker.Value;

            listaTurnos.Add(turno);
           GuardarTurnos();
          ActualizarListaTurnos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            int numeroBuscado;

            if (int.TryParse(txtNumeroTurno.Text, out numeroBuscado))
            {
                var turno = listaTurnos.FirstOrDefault(t => t.NumeroTurno == numeroBuscado);

                

                if (turno != null)
                {
                    lstTurnos.Items.Add(turno.Descripcion());
                }
                else
                {
                    MessageBox.Show("Turno no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEliminar;
            if (int.TryParse(txtNumeroTurno.Text, out idEliminar))
            {
                var turno = listaTurnos.FirstOrDefault(t => t.NumeroTurno == idEliminar);
                if (turno != null)
                {
                    listaTurnos.Remove(turno);
                    GuardarTurnos();
                    ActualizarListaTurnos();
                }
                else
                {
                    MessageBox.Show("Turno no encontrado.");
                    
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
        private void ActualizarListaTurnos()
        {
            lstTurnos.Items.Clear();
            foreach (var turno in listaTurnos)
            {
                lstTurnos.Items.Add(turno.Descripcion());
            }
        }
        private void GuardarTurnos()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Turno>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializer.Serialize(fs, listaTurnos);
            }
        }

        private void CargarTurnos()
        {
            if (File.Exists(rutaArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Turno>));
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    listaTurnos = (List<Turno>)serializer.Deserialize(fs);
                }
                ActualizarListaTurnos();
            }
        }

    }
}
