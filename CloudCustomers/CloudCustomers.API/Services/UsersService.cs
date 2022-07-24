using System;
using CloudCustomers.API.Models;

public interface IUsersService {
  public Task<List<User>> GetAllUsers();
}

public class UsersService : IUsersService {
  private readonly HttpClient _httpClient;

  public UsersService(HttpClient httpClient) {
    _httpClient = httpClient;
    }

  public async Task<List<User>> GetAllUsers() {
    var usersResponce = await _httpClient.GetAsync("https://example.com");

    if (usersResponce.StatusCode == System.Net.HttpStatusCode.NotFound) {
      return new List<User>();
    }
    var responceContent = usersResponce.Content;
    var allUsers = await responceContent.ReadFromJsonAsync<List<User>>();
    return allUsers.ToList();
  }
}
