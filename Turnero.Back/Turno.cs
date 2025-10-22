using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.Back
{
    public class Turno
    {
        public int NumeroTurno { get; set; }
        public string Paciente { get; set; }
        public string Doctor { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public string Descripcion()
        {
            return $"Turno #{NumeroTurno} - Paciente: {Paciente} - Doctor: {Doctor} - Fecha: {Fecha:dd/MM/yyyy HH:mm}";
        }



    }
}
