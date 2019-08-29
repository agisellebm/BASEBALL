using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugadores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos =
                new List<Equipo>();

            Equipo yaquis = new Equipo("Reinas del Sur");
            yaquis.Entrenador = "Aileen Balderrama";
            yaquis.CiudadOrigen = "Ciudad Obregon";

            yaquis.Jugadores.Add(
               new Jugador("Harry Styles", 5));
            yaquis.Jugadores.Add(
               new Jugador("Zayn", 45));
            yaquis.Jugadores.Add(
               new Jugador("Gallo de Oro", 7));
            yaquis.Jugadores.Add(
               new Jugador("Jenni Rivera", 87));
            yaquis.Jugadores.Add(
               new Jugador("Brad Pitt", 12));
            yaquis.Jugadores.Add(
               new Jugador("La Tigresa", 34));
            yaquis.Jugadores.Add(
               new Jugador("Chupitos", 23));
            yaquis.Jugadores.Add(
             new Jugador("Alex Borquez", 99));
            yaquis.Jugadores.Add(
             new Jugador("Emiliano el profe", 55));


        }
    }
}
