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
        public async Task<List<Fish>> GetAll()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync("https://www.fishwatch.gov/api/species");
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Fish>>(json);
            }

            return new List<Fish>();
        }
    }
}