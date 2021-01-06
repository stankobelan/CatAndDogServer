using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatAndDogServer.Data;
using CatAndDogServer.Models;
using Microsoft.AspNetCore.Cors;

namespace CatAndDogServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly DataContext _context;

        public CatsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cats
        [HttpGet]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<IEnumerable<Cat>>> GetCats()
        {
            return await _context.Cats.ToListAsync();
        }

        // GET: api/Cats/5
        [HttpGet("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Cat>> GetCat(int id)
        {
            var cat = await _context.Cats.FindAsync(id);

            if (cat == null)
            {
                return NotFound();
            }

            return cat;
        }

        // PUT: api/Cats/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [EnableCors("reactAPP")]
        public async Task<IActionResult> PutCat(int id, Cat cat)
        {
            if (id != cat.Id)
            {
                return BadRequest();
            }

            var DbCat = _context.Cats.Find(id);
            if (DbCat == null)
            {
                return NotFound();
            }
            else
            {
                DbCat.PocetKrmeni = cat.PocetKrmeni;
                DbCat.PocetMaciatok = cat.PocetMaciatok;

                _context.Entry(DbCat).State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(DbCat);
        }

        // POST: api/Cats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Cat[]>> PostCats(Cat[] cats)
        {
            var dbList = new List<Cat>();
            foreach (var cat in cats)
            {
                var item = new Cat()
                {
                    Name = cat.Name,
                    DatumNarodenia = cat.DatumNarodenia,
                    PetOwnerId = cat.PetOwnerId,
                    PocetKrmeni = cat.PocetKrmeni,
                    PocetMaciatok = cat.PocetMaciatok
                };

                dbList.Add(item);
            }


            await _context.Cats.AddRangeAsync(dbList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostCats", dbList.ToArray());
        }

        // DELETE: api/Cats/5
        [HttpDelete("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Cat>> DeleteCat(int id)
        {
            var cat = await _context.Cats.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.Cats.Remove(cat);
            await _context.SaveChangesAsync();

            return cat;
        }

        private bool CatExists(int id)
        {
            return _context.Cats.Any(e => e.Id == id);
        }
    }
}
