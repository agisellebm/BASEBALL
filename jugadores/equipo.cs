using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugadores
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }

        public string Entrenador { get; set; } 

        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Nombre = "Reinas del Sur";
            CiudadOrigen = "Ciudad Obregon";
            Entrenador = "Aileen Balderrama";
            Jugadores = new List<Jugador>();
        }


    }
}
