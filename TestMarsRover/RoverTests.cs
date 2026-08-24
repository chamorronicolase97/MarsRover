namespace TestMarsRover
{
    [TestClass]
    public sealed class RoverTests
    {
        [TestMethod]
        public void InicializaEnLaPosicionXIndicada()
        {
            var rover = new Rover(0, 0, N);

            var x = rover.x;

            Assert.AreEqual(0, x);
        }
    }
}
