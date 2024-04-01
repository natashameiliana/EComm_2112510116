using EComm_2112510116.Shared;

namespace EComm_2112510116.Client.Services.KategoriService
{
    
        public interface IKategoriService
        {
            List<Kategori> Kategoris { get; set; }
            Task GetAllKategori();
            Task<Kategori> GetKategoriById(int Id);

            //Create, Update, Delete
            Task CreateKategori(Kategori kategori);
            Task DeleteKategori(int Id);
            Task UpdateKategori(Kategori kategori, int Id);

    }
    
}
