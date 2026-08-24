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

            var posicion = rover.Avanzar();

            Assert.AreEqual(posicion, "0,1");
        }

        [TestMethod]
        public void GirarAlaIzquierda()
        {
            var rover = new Rover(0, 0, "N");

            var orientacion = rover.GirarALaIzquierda();

            Assert.AreEqual(orientacion, "O");
        }

        [TestMethod]
        public void GirarAlaDerecha()
        {
            var rover = new Rover(0, 0, "N");

            var orientacion = rover.GirarALaDerecha();

            Assert.AreEqual(orientacion, "E");
        }

        [TestMethod]
        public void Retroceder()
        {
            var rover = new Rover(0, 0, "N");

            var posicion = rover.Retroceder();

            Assert.AreEqual(posicion, "0,-1");
        }

        [TestMethod]
        public void Mover()
        {
            var rover = new Rover(0, 0, "N");

            var posicion = rover.Mover("FFRFF");

            Assert.AreEqual(posicion, "2,2");
        }

    }
}

