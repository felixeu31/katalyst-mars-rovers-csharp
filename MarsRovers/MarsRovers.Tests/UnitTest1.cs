using FluentAssertions;

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
            position.Should().Be("0:0:N");
        }

        [Test]
        public void initial_position_oriented_east_returned_when_rotate_right()
        {
            // Arrange
            var marsRover = new MarsRovers();

            // Act
            string position = marsRover.Execute("R");

            // Assert
            position.Should().Be("0:0:E");
        }


        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left()
        {
            // Arrange
            var marsRover = new MarsRovers();

            // Act
            string position = marsRover.Execute("L");

            // Assert
            position.Should().Be("0:0:W");
        }

        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left_twice()
        {
            // Arrange
            var marsRover = new MarsRovers();

            // Act
            string position = marsRover.Execute("LL");

            // Assert
            position.Should().Be("0:0:S");
        }


        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left_three_times()
        {
            // Arrange
            var marsRover = new MarsRovers();

            // Act
            string position = marsRover.Execute("LLL");

            // Assert
            position.Should().Be("0:0:E");
        }
    }
}