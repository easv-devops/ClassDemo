
using Xunit;

namespace UnitTests;

public class ProgramTest
{
    [Fact]
    public void GetGreetingMessage_ShouldReturnDroneCI_GivenDroneCIBranch()
    {
        // Arrange
        Environment.SetEnvironmentVariable("DRONE", "true");
        
        // Act
        var result = Program.GetGreetingMessage();
        
        // Assert
        Assert.Equal("Hello, Drone CI!", result);
    }
}