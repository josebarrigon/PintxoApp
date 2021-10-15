using System;
using System.Collections.Generic;
using System.Text;

namespace PintxoApp.Models
{
    public class Partida
    {
        public Partida(int nJugadores,string[] nombres)
        {
            NJugadores = nJugadores;
            Jugadores = new List<Jugador>();
            Puntos = new int[((40 / NJugadores) - 1) * 2 + NJugadores * 2, NJugadores];
            PintxosBool = new bool[((40 / NJugadores) - 1) * 2 + NJugadores * 2, NJugadores];
            Pintxos = new int[NJugadores];
            for(int i = 0; i < nJugadores; i++)
            {
                Jugadores.Add(new Jugador(nombres[i], i));
            }
        }

        public List<Jugador> Jugadores { get; set; }
        public int NRonda { get; set; }

        private int[,] Puntos { get; set; }

        private int[] Pintxos { get; set; }

        private bool[,] PintxosBool { get; set; }

        public int NJugadores { get; set; }

    }
}
