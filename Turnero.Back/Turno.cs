using System;
<<<<<<< HEAD

namespace Turnero.Back
{
    [Serializable]
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnero.Back
{
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
    public class Turno
    {
        public int NumeroTurno { get; set; }
        public string Paciente { get; set; }
        public string Doctor { get; set; }
<<<<<<< HEAD
        public DateTime Fecha { get; set; }
=======

        public DateTime Fecha { get; set; }

>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
        public DateTime Hora { get; set; }

        public string Descripcion()
        {
<<<<<<< HEAD
            return $"Turno {NumeroTurno} - Paciente: {Paciente} - Doctor: {Doctor} - Fecha: {Fecha:dd/MM/yyyy} Hora: {Hora:HH:mm}";
        }
    }
}

=======
            return $"Turno #{NumeroTurno} - Paciente: {Paciente} - Doctor: {Doctor} - Fecha: {Fecha:dd/MM/yyyy HH:mm}";
        }



    }
}
>>>>>>> 1645dc0dfd8ebab9efb0d64dd12f3770d2602bd5
