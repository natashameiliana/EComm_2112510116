using EComm_2112510116.Shared;

namespace EComm_2112510116.Client.Services.VarianService
{
    public interface IVarianService
    {
        List<Varian> Varians { get; set; }
        Task GetAllVarian();
        Task<Varian> GetVarianById(int Id);

        //Create, Update, Delete
        Task CreateVarian(Varian varian);
        Task DeleteVarian(int Id);
        Task UpdateVarian(Varian varian);
    }
}
