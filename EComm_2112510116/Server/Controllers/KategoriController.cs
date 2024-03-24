using EComm_2112510116.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EComm_2112510116.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        public static List<Kategori> kategoris = new List<Kategori>();
        private readonly DataContext _context;

        public KategoriController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Kategori>>> GetAllKategoris()
        {
            var kategoris = await _context.Kategori.ToListAsync();
            return Ok(kategoris);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kategori>> GetKategorisById(int id)
        {
            var prod = kategoris.FirstOrDefault(p => p.IdKategori == id);
            if (prod == null)
            {
                return NotFound("Kategori tidak ditemukan.");
            }
            return Ok(prod);
        }

        //Read Edit 21/3/24
        private async Task<List<Kategori>> GetDbKategori()
        {
            return await _context.Kategori.ToListAsync();
        }

        //Create Kategori
        [HttpPost]
        public async Task<ActionResult<List<Kategori>>> CreateKategori(Kategori kategori)
        {
            _context.Kategori.Add(kategori);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }


        //Update Kategori
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Kategori>>> UpdateKategori(Kategori kategori, int id)
        {
            var dbKategori = await _context.Kategori.FirstOrDefaultAsync(sh => sh.IdKategori == id);
            if (dbKategori == null) return NotFound("Data tidak ditemukan");

            dbKategori.IdKategori = id;
            dbKategori.Nama = kategori.Nama;

            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }


        //Delete Kategori
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Kategori>>> DeleteKategori(int id)
        {
            var dbKategori = await _context.Kategori.FirstOrDefaultAsync(sh => sh.IdKategori == id);

            if (dbKategori == null) return NotFound("Data Tidak Ditemukan");

            _context.Kategori.Remove(dbKategori);
            await _context.SaveChangesAsync();
            return Ok(await GetDbKategori());
        }

    }
}
