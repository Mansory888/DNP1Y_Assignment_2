using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_1.Data
{
    public class CloudUserService : ITUserInterface
    {
        private readonly HttpClient Client;
        private string uri = "https://localhost:5003";

        public CloudUserService()
        {
            Client = new HttpClient();
        }

        public async Task AddUser(User user)
        {
            string toAdd = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(toAdd, Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = await Client.PostAsync(uri + "/User", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
        

        public async Task<User> ValidateUserOnCloud(string userName, string Password)
        {
            
            HttpResponseMessage response =
                await Client.GetAsync($"https://localhost:5003/User?username={userName}&password={Password}");
                                             
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                
                return resultUser;
            } 
            throw new Exception("User not found");
        }
    }
}