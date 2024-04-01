using EComm_2112510116.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EComm_2112510116.Client.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public KategoriService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Kategori> Kategoris { get ; set ; } = new List<Kategori>();


        //create
        public async Task CreateKategori(Kategori kategori)
        {
            var result = await _http.PostAsJsonAsync("api/kategori", kategori);
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationManager.NavigateTo("/manajemen-kategori");
        }

        //delete
        public async Task DeleteKategori(int id)
        {
            var result = await _http.DeleteAsync($"api/kategori/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationManager.NavigateTo("/manajemen-kategori");
        }

        public async Task GetAllKategori()
        {
            var result = await _http.GetFromJsonAsync<List<Kategori>>("api/Kategori");
            if (result != null)
            {
                Kategoris = result;
            }
        }

        public async Task<Kategori> GetKategoriById(int id)
        {
            var result = await _http.GetFromJsonAsync<Kategori>($"api/Kategori/{id}");
            if (result != null) 
            {
                return result;
            }
            
            throw new Exception("Data Kategori Tidak Ditemukan");
        }

        
        //update
        public async Task UpdateKategori(Kategori kategori, int Id)
        {
            var result = await _http.PutAsJsonAsync($"api/kategori/{Id}", kategori);
            var response = await result.Content.ReadFromJsonAsync<List<Kategori>>();
            Kategoris = response;
            _navigationManager.NavigateTo("/manajemen-kategori");
        }

        //public Task UpdateKategori(Kategori kategori, int Id)
        //{
        //   throw new NotImplementedException();
        //}
    }
}
