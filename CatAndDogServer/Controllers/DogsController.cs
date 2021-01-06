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
    public class DogsController : ControllerBase
    {
        private readonly DataContext _context;

        public DogsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Dogs
        [HttpGet]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<IEnumerable<Dog>>> GetDogs()
        {
            return await _context.Dogs.ToListAsync();
        }

        // GET: api/Dogs/5
        [HttpGet("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Dog>> GetDog(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);

            if (dog == null)
            {
                return NotFound();
            }

            return dog;
        }

        // PUT: api/Dogs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [EnableCors("reactAPP")]
        public async Task<IActionResult> PutDog(int id, Dog dog)
        {
            if (id != dog.Id)
            {
                return BadRequest();
            }

            Dog Dbdog = await _context.Dogs.FindAsync(id);
            if (Dbdog == null)
            {
                return NotFound();
            }
            else
            {
                Dbdog.PocetKrmeni = dog.PocetKrmeni;
                Dbdog.PocetUhriznuti = dog.PocetUhriznuti;
                _context.Entry(Dbdog).State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }

            return Ok(Dbdog);
        }

        // POST: api/Cats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Dog[]>> PostDogs(Dog[] cats)
        {
            var dbList = new List<Dog>();
            foreach (var cat in cats)
            {
                var item = new Dog()
                {
                    Name = cat.Name,
                    DatumNarodenia = cat.DatumNarodenia,
                    PetOwnerId = cat.PetOwnerId,
                    PocetKrmeni = cat.PocetKrmeni,
                    PocetUhriznuti = cat.PocetUhriznuti
                };

                dbList.Add(item);
            }


            await _context.Dogs.AddRangeAsync(dbList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostDogs", dbList.ToArray());
        }


        // DELETE: api/Dogs/5
        [HttpDelete("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Dog>> DeleteDog(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }

            _context.Dogs.Remove(dog);
            await _context.SaveChangesAsync();

            return dog;
        }

        private bool DogExists(int id)
        {
            return _context.Dogs.Any(e => e.Id == id);
        }
    }
}
