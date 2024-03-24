using EComm_2112510116.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EComm_2112510116.Client.Services.VarianService
{
    public class VarianService : IVarianService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public VarianService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Varian> Varians { get; set; } = new List<Varian>();


        //create
        public async Task CreateVarian(Varian varian)
        {
            var result = await _http.PostAsJsonAsync("api/varian", varian);
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationManager.NavigateTo("/manajemen-varian");
        }

        //delete
        public async Task DeleteVarian(int id)
        {
            var result = await _http.DeleteAsync($"api/varian/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationManager.NavigateTo("/manajemen-varian");
        }

        public async Task GetAllVarian()
        {
            var result = await _http.GetFromJsonAsync<List<Varian>>("api/Varian");
            if (result != null)
            {
                Varians = result;
            }
        }

        //read
        public async Task<Varian> GetVarianById(int Id)
        {
            var result = await _http.GetFromJsonAsync<Varian>($"api/Varian/{Id}");
            if (result != null) { }
            return result;
            throw new Exception("Data Varian Tidak Ditemukan");
        }

        public async Task UpdateVarian(Varian varian)
        {
            var result = await _http.PutAsJsonAsync($"api/varian/{varian.IdVarian}", varian);
            var response = await result.Content.ReadFromJsonAsync<List<Varian>>();
            Varians = response;
            _navigationManager.NavigateTo("/manajemen-varian");
        }
    }
}
