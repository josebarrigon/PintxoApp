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
            NRondas = ((40 / NJugadores) - 1) * 2 + NJugadores * 2;
            Puntos = new int[NRondas, NJugadores];
            PintxosBool = new bool[NRondas, NJugadores];
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

        public int NRondas { get; set; }

    }
}
