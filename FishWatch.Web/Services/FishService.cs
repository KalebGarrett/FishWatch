using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FishWatch.Models;

namespace FishWatch.Web.Services
{
    public class FishService
    {
        public List<Fish> Fishes { get; set; } = null; 
        public async Task<List<Fish>> GetAll()
        {
            if (Fishes != null)
            {
                return Fishes;
            }
            using var client = new HttpClient();
            var result = await client.GetAsync("https://www.fishwatch.gov/api/species");
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                
                Fishes = JsonSerializer.Deserialize<List<Fish>>(json);
                return Fishes;
            }
            
            return new List<Fish>();
        }

        public async Task<Fish> Get(string id)
        {
            if (Fishes == null)
            {
                await GetAll();
            }

            var fish = Fishes.FirstOrDefault(x => x.Id == id.ToLower());
            return fish;
        }

        public async Task<List<Fish>> Search(string query)
        {
            if (Fishes == null)
            {
                await GetAll();
            }

            var fishes = Fishes.Where(x => x.SpeciesName.ToLower().Contains(query.ToLower()));
            return fishes.ToList();
        }
    }
}