using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Models;

namespace Assignment_1.Data
{
    public class CloudFamilyManager : ITFamilyManager
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient Client;
        private List<Family> families;

        public CloudFamilyManager()
        {
            Client = new HttpClient();
            LoadData();
        }

        public async Task LoadData()
        {
            families = await FetchFamilies();
        }


        private async Task<List<Family>> FetchFamilies()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(uri + "/Family");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            
            List<Family> families = JsonSerializer.Deserialize<List<Family>>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return families;
        }

        public IList<Family> getFamilies()
        {
            return families;
        }

        public IList<Adult> getAdults()
        {
            List<Adult> adults = new List<Adult>();

            foreach (var family in families)
            {
                adults.AddRange(family.Adults);
            }

            return adults;
        }

        public Family get(int id)
        {
            return families.FirstOrDefault(f => f.Id == id);
        }       

        public void AddAdult(Adult adult, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Adults.Add(adult);
                    RewriteToFileOnCloud(family);
                }
            }
        }

        public void AddPet(Pet pet, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Pets.Add(pet);
                    RewriteToFileOnCloud(family);
                }
            }
        }

        public void AddChild(Child child, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Children.Add(child);
                    RewriteToFileOnCloud(family);
                }
            }
        }

        public void RemoveFamily(int FamilyId)
        {
            foreach (var family in families.ToList())
            {
                if (family.Id == FamilyId)
                {
                    families.Remove(family);
                }
            }

            RemoveFamilyOnCloud(FamilyId);
        }

        public void AddFamily(Family family)
        {
            families.Add(family);
            AddFamilyOnCloud(family);
        }

        private async Task RemoveFamilyOnCloud(int familyId)
        {
            HttpResponseMessage response = await Client.DeleteAsync($"{uri}/Family/{familyId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        private async Task AddFamilyOnCloud(Family family)
        {
            string toAdd = JsonSerializer.Serialize(family);
            HttpContent content = new StringContent(toAdd, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Client.PostAsync(uri + "/Family", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        private async Task RewriteToFileOnCloud(Family family)
        {
            string familiesAsJson = JsonSerializer.Serialize(family);
            HttpContent content = new StringContent(familiesAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await Client.PatchAsync($"{uri}/Family?familyId={family.Id}", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
    }
}