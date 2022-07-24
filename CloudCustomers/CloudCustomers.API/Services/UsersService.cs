using System;
using CloudCustomers.API.Models;
using CloudCustomers.API.Models.Config;
using Microsoft.Extensions.Options;

public interface IUsersService {
  public Task<List<User>> GetAllUsers();
}

public class UsersService : IUsersService {
  private readonly HttpClient _httpClient;
  private readonly UsersApiOptions _apiConfig;

  public UsersService(HttpClient httpClient, IOptions<UsersApiOptions> apiConfig) {
    _httpClient = httpClient;
    _apiConfig = apiConfig.Value;
    }

  public async Task<List<User>> GetAllUsers() {
    var usersResponce = await _httpClient
      .GetAsync(_apiConfig.Endpoint);

    if (usersResponce.StatusCode == System.Net.HttpStatusCode.NotFound) {
      return new List<User>();
    }
    var responceContent = usersResponce.Content;
    var allUsers = await responceContent.ReadFromJsonAsync<List<User>>();
    return allUsers.ToList();
  }
}
