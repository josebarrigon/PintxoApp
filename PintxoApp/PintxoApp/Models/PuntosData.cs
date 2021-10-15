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
            return PuntosJugadores;
        }
    }
}
