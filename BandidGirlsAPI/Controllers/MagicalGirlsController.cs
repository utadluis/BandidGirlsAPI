using BandidGirlsAPI.Data;
using BandidGirlsAPI.DTOs;
using BandidGirlsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BandidGirlsAPI.Controllers
{
    [Route("api/magicalGirls")]
    [ApiController]
    public class MagicalGirlsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MagicalGirlsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MagicalGirls>>> Get()
        {
            var magicalGirls = await _context.MagicalGirls
                   .Include(x => x.HistorialsDb)
                   .ToListAsync();

            return Ok(magicalGirls);
        }

        [HttpPost]
        public async Task<ActionResult> Post(InsertMagicalGirlsDTO magicalGirlsDto)
        {
            var newGirl = new MagicalGirls
            {
                Name = magicalGirlsDto.Name,
                Age = magicalGirlsDto.Age,
                Origun_City = magicalGirlsDto.Origun_City,
                Status = "Active",
                Contract_Date = magicalGirlsDto.Contract_Date
            };

            _context.MagicalGirls.Add(newGirl);
            await _context.SaveChangesAsync();

            var historial = new Historial
            {
                Status = "Active",
                PreviussState = "N/A",
                NewState = "Active",
                ChangeDade = DateTime.UtcNow,
                MagicalGirlId = newGirl.Id
            };

            _context.Historials.Add(historial);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = newGirl.Id }, newGirl);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            var girl = await _context.MagicalGirls
                .Include(x => x.HistorialsDb)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (girl == null)
            {
                return NotFound(new { message = "Magical Girl not found" });
            }

            return Ok(girl);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteGirl(int id)
        {
            var girl = await _context.MagicalGirls.FindAsync(id);

            if (girl == null)
            {
                return NotFound(new { message = "Magical Girl not found" });
            }

            _context.MagicalGirls.Remove(girl);

            var historial = new Historial
            {
                Status = "Deleted",
                PreviussState = girl.Status,
                NewState = "Deleted",
                ChangeDade = DateTime.UtcNow,
                MagicalGirlId = girl.Id
            };

            _context.Historials.Add(historial);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Magical Girl deleted successfully" });
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateGirl(int id, MagicalGirlsUpdateDTO magicalGirlsUpdateDTO)
        {
            var girl = await _context.MagicalGirls.FindAsync(id);

            if (girl == null)
            {
                return NotFound(new { message = "Magical Girl not found" });
            }

            girl.Name = magicalGirlsUpdateDTO.Name;
            girl.Age = magicalGirlsUpdateDTO.Age;
            girl.Origun_City = magicalGirlsUpdateDTO.Origun_City;
            girl.Status = magicalGirlsUpdateDTO.Status;
            girl.Contract_Date = magicalGirlsUpdateDTO.Contract_Date;

            var historial = new Historial
            {
                Status = magicalGirlsUpdateDTO.Status,
                PreviussState = girl.Status,
                NewState = magicalGirlsUpdateDTO.Status,
                ChangeDade = DateTime.UtcNow,
                MagicalGirlId = girl.Id
            };

            _context.Historials.Add(historial);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Magical Girl updated successfully" });
        }
    }
}
