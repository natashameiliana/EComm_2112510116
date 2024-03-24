using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm_2112510116.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdukController : ControllerBase
    {
        public static List<Produk> produks = new List<Produk>();
        private readonly DataContext _context;

        public ProdukController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produk>>> GetAllProduks()
        {
            var produks = await _context.Produk.ToListAsync();
            return Ok(produks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Produk>> GetProduksById(int id)
            {
            var prod = await _context.Produk.FirstOrDefaultAsync(p => p.IdProduk == id);
            if (prod == null)
            {
                return NotFound("Data Produk tidak ditemukan.");
            }
            return Ok(prod);
             }

        //Code tambahan materi ke 6 CRUD 3 - Edit 20/3/24
        private async Task<List<Produk>> GetDbProduk()
        {
            return await _context.Produk.ToListAsync();
        }

        //Create Produk
        [HttpPost]
        public async Task<ActionResult<List<Produk>>> CreateProduk(Produk produk) 
        { 
            _context.Produk.Add(produk);
            await _context.SaveChangesAsync();
            return Ok(await GetDbProduk());
        }

        //Update Produk
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Produk>>> UpdateProduk(Produk produk, int id) 
        {
            var dbProduk = await _context.Produk.FirstOrDefaultAsync(sh => sh.IdProduk == id);
            if(dbProduk == null) return NotFound("Data tidak ditemukan");  
            
            dbProduk.IdProduk = id;
            dbProduk.Nama = produk.Nama;
            dbProduk.Deskripsi = produk.Deskripsi;
            dbProduk.Harga = produk.Harga;
            dbProduk.HargaOriginal = produk.HargaOriginal;
            dbProduk.DateCreated = produk.DateCreated;
            dbProduk.DateUpdated  = produk.DateUpdated;
            dbProduk.IsDeleted = produk.IsDeleted;
            dbProduk.IsPublic = produk.IsPublic;
            dbProduk.GambarUrl = produk.GambarUrl;
            dbProduk.IdKategori = produk.IdKategori;

            await _context.SaveChangesAsync();
            return Ok(await GetDbProduk());
        }

        //Delete Produk

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Produk>>> DeleteProduk(int id)
        {
            var dbProduk = await _context.Produk.FirstOrDefaultAsync(sh => sh.IdProduk == id);

            if (dbProduk == null) return NotFound("Data Tidak Ditemukan");

            _context.Produk.Remove(dbProduk);
            await _context.SaveChangesAsync();
            return Ok(await GetDbProduk());
        }

        }
    }

