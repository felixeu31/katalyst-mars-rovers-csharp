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
            var marsRover = new MarsRovers();
            // Act
            string position = marsRover.Execute(string.Empty);

            // Assert

            Assert.AreEqual("0:0:N", position);
        }

        [Test]
        public void initial_position_oriented_east_returned_when_rotate_right()
        {
            // Arrange
            var marsRover = new MarsRovers();
            // Act
            string position = marsRover.Execute("R");

            // Assert
            Assert.AreEqual("0:0:E", position);
        }
    }

    public class MarsRovers
    {
        public string Execute(string command)
        {
            if (command.Equals("R"))
                return "0:0:E";

            return "0:0:N";
        }
    }
}