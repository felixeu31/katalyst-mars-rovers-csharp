namespace MarsRovers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void initial_position_returned_when_no_movements()
        {
            // Arrange

            // Act
            string position = string.Empty;

            // Assert
            Assert.AreEqual("0:0:N", position);
        }
    }
}