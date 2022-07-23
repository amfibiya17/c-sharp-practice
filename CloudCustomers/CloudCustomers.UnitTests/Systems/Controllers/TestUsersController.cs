using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public void Get_OnSuccess_ReturnsStatusCode200() {
      // Arrange
      var sut = new UsersController();
      // Act
      var result = sut.Get();
      // Assert
      result.StatusCode.Should().Be(200);
    }
}