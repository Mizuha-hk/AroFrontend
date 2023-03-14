namespace allo_frontend;
using System.Net.Http.Json;

public class Services
{
    private readonly HttpClient httpClient;
    public Services(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<User>> GetUserInfo(string uuid)
    {
        try
        {
            var userInfo = await this.httpClient.GetFromJsonAsync<IEnumerable<User>>("user/"+uuid);
            return userInfo;
        }
        catch(Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        try
        {
            var allUserInfo = await this.httpClient.GetFromJsonAsync<IEnumerable<User>>("user/all");
            return allUserInfo;
        }
        catch(Exception)
        {
            throw;
        }
    }
}