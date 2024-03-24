using EComm_2112510116.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EComm_2112510116.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarianController : ControllerBase
    {
        public static List<Varian> varians = new List<Varian>();
        private readonly DataContext _context;
        public VarianController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Varian>>> GetAllVarians()
        {
            var varians = await _context.Varian.ToListAsync();
            return Ok(varians);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Varian>> GetVariansById(int id)
        {
            var prod = varians.FirstOrDefault(p => p.IdVarian == id);
            if (prod == null)
            {
                return NotFound("Varian tidak ditemukan.");
            }
            return Ok(prod);
        }


        //Read Edit 21/3/24
        private async Task<List<Varian>> GetDbVarian()
        {
            return await _context.Varian.ToListAsync();
        }


        //Create Varian
        [HttpPost]
        public async Task<ActionResult<List<Varian>>> CreateVarian(Varian varian)
        {
            _context.Varian.Add(varian);
            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }


        //Update Varian
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Varian>>> UpdateVarian(Varian varian, int id)
        {
            var dbVarian = await _context.Varian.FirstOrDefaultAsync(sh => sh.IdVarian == id);
            if (dbVarian == null) return NotFound("Data tidak ditemukan");

            dbVarian.IdVarian = id;
            dbVarian.Nama = varian.Nama;

            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }


        //Delete Varian
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Varian>>> DeleteVarian(int id)
        {
            var dbVarian = await _context.Varian.FirstOrDefaultAsync(sh => sh.IdVarian == id);

            if (dbVarian == null) return NotFound("Data Tidak Ditemukan");

            _context.Varian.Remove(dbVarian);
            await _context.SaveChangesAsync();
            return Ok(await GetDbVarian());
        }
    }
}

