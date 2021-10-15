using System;
using System.Collections.Generic;
using System.Text;

namespace PintxoApp.Models
{
    public class PuntosData
    {
        private List<Puntos> PuntosJugadores;

        public PuntosData()
        {
            PuntosJugadores = new List<Puntos>();
        }

        public List<Puntos> GetPuntos()
        {
            Puntos puntos = new Puntos { Ronda = "1" ,PuntosJ1 = 1, PuntosJ2 = 2, PuntosJ3 = 3, PuntosJ4 = 4, PuntosJ5 = 5 };
            PuntosJugadores.Add(puntos);
            return PuntosJugadores;
        }
    }
}
