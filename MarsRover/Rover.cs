using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public string Orientacion { get; set; }

        public Rover(int posicionX, int posicionY, string orientacion)
        {
            PosicionX = posicionX;
            PosicionY = posicionY;
            Orientacion = orientacion;
        }

        public string Avanzar(string comando)
        {
            if (comando == "F")
            {
                PosicionY += 1;
            }
            return $"{PosicionX},{PosicionY}";
        }

        public string GirarALaIzquierda()
        {
            if (Orientacion == "N")
            {
                Orientacion = "O";
            }
            return Orientacion;
        }

        public string GirarALaDerecha()
        {
            if (Orientacion == "N")
            {
                Orientacion = "E";
            }
            return Orientacion;
        }

    }
}
