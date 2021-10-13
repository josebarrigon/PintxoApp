using System;
using System.Collections.Generic;
using System.Text;

namespace PintxoApp.Models
{
    class Jugador
    {
        public Jugador(string nombre, int index)
        {
            Nombre = nombre;
            Index = index;
        }

        public string Nombre { get; set; }

        public int Index { get; set; }
    }
}
