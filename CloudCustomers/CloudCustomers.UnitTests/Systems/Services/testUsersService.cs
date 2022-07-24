using System;
using System.Threading.Tasks;
using CloudCustomers.API.Models;
using CloudCustomers.UnitTests.Fixtures;
using CloudCustomers.UnitTests.Helpers;
using Moq;
using Moq.Protected;
using Xunit;
using System.Threading;

namespace CloudCustomers.UnitTests.Systems.Services
{

  public class TestUsersService
  {
    [Fact]
    public async Task GetAllUsers_WhenCalled_InvokesHttpGetRequest() {
      // Arrange
      var expectedResponce = UsersFixture.GetTestUsers();
      var handlerMock = MockHttpMessageHandler<User>.SetupBasicGetResourceList(expectedResponce);
      var httpClient = new HttpClient(handlerMock.Object);
      var sut = new UsersService(httpClient);

      // Act
      await sut.GetAllUsers();

      // Assert
      handlerMock
        .Protected()
        .Verify(
        "SendAsync",
        Times.Exactly(1),
        ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get),
        ItExpr.IsAny<CancellationToken>()
        );
    }
  }

}
