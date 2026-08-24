using MarsRover;

namespace TestMarsRover
{
    [TestClass]
    public sealed class RoverTests
    {
        [TestMethod]
        public void InicializaEnLaPosicionXIndicada()
        {
            var rover = new Rover(0, 0, "N");

            var x = rover.PosicionX;

            Assert.AreEqual(0, x);
        }        
    
    
        [TestMethod]
        public void InicializaEnLaPosicionYIndicada()
        {
            var rover = new Rover(0, 0, "N");

            var y = rover.PosicionY;

            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void Avanzar()
        {
            var rover = new Rover(0, 0, "N");

            var posicion = rover.Avanzar("F");

            Assert.AreEqual(posicion, "0,1");
        }

    }
}

