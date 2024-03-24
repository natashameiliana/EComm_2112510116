using EComm_2112510116.Shared;
using System.ComponentModel;

namespace EComm_2112510116.Client.Services.ProdukService
{
    public interface IProdukService
    {
        List<Produk> Produks { get; set; }
        Task GetAllProduk();
        Task<Produk> GetProdukById(int Id);

        //Create, Update, Delete
        Task CreateProduk(Produk produk);
        Task DeleteProduk(int Id);
        Task UpdateProduk(Produk produk);

    }
}
