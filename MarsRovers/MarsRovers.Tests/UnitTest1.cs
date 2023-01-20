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
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute(string.Empty);

            // Assert
            position.Should().Be("0:0:N");
        }

        [Test]
        public void initial_position_oriented_east_returned_when_rotate_right()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("R");

            // Assert
            position.Should().Be("0:0:E");
        }


        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("L");

            // Assert
            position.Should().Be("0:0:W");
        }

        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left_twice()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("LL");

            // Assert
            position.Should().Be("0:0:S");
        }


        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left_three_times()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("LLL");

            // Assert
            position.Should().Be("0:0:E");
        }

        [Test]
        public void initial_position_oriented_west_returned_when_rotate_left_four_times()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("LLLL");

            // Assert
            position.Should().Be("0:0:N");
        }


        [Test]
        public void initial_position_oriented_east_returned_when_rotate_right_two_times()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("RR");

            // Assert
            position.Should().Be("0:0:S");
        }


        [Test]
        public void one_cell_up_when_first_move()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("M");

            // Assert
            position.Should().Be("0:1:N");
        }

        [Test]
        public void one_cell_right_after_rotate_right_and_move()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("RM");

            // Assert
            position.Should().Be("1:0:E");
        }


        [TestCase("MMRMMLM", "2:3:N")]
        [TestCase("RMMLM", "2:1:N")]
        public void compound_commands_within_limits(string commands, string output)
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute(commands);

            // Assert
            position.Should().Be(output);
        }


        [Test]
        public void compound_commands_with_up_overflow()
        {
            // Arrange
            var marsRover = MarsRover.Init();

            // Act
            string position = marsRover.Execute("MMMMMMMMMM");

            // Assert
            position.Should().Be("0:0:N");
        }


    }
}