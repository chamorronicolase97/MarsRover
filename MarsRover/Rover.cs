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
                switch(Orientacion)
                {
                    case "N":
                        PosicionY += 1;
                        break;
                    case "E":
                        PosicionX += 1;
                        break;
                    case "S":
                        PosicionY -= 1;
                        break;
                    case "O":
                        PosicionX -= 1;
                        break;
                }
            }
            return $"{PosicionX},{PosicionY}";
        }

        public string Retroceder(string comando)
        {
            if (comando == "B")
            {
            switch(Orientacion)
                {
                    case "N":
                        PosicionY -= 1;
                        break;
                    case "E":
                        PosicionX -= 1;
                        break;
                    case "S":
                        PosicionY += 1;
                        break;
                    case "O":
                        PosicionX += 1;
                        break;
                }
            }
            return $"{PosicionX},{PosicionY}";
        }

        public string GirarALaIzquierda()
        {
            switch (Orientacion)
            {
                case
                    "N":
                    Orientacion = "O";
                    break;
                case "O":
                    Orientacion = "S";
                    break;
                case "S":
                    Orientacion = "E";
                    break;
                case "E":
                    Orientacion = "N";
                    break;
            }
            return Orientacion;
        }

        public string GirarALaDerecha()
        {
            switch(Orientacion)
                {
                case
                    "N":
                    Orientacion = "E";
                    break;
                case "E":
                    Orientacion = "S";
                    break;
                case "S":
                    Orientacion = "O";
                    break;
                case "O":
                    Orientacion = "N";
                    break;
            }
            return Orientacion;
        }

    }
}
