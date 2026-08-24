using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int PosicionX { get; set; }        
        public Rover(int posicionX, int posicionY, string orientacion)
        {
            PosicionX = posicionX;
        }
    }
}
