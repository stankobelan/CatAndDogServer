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
    public class PetOwnersController : ControllerBase
    {
        private readonly DataContext _context;

        public PetOwnersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PetOwners
        [HttpGet]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<IEnumerable<PetOwner>>> GetPetOwners()
        {
            return await _context.PetOwners.ToListAsync();
        }

        // GET: api/PetOwners/5
        [HttpGet("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<PetOwner>> GetPetOwner(int id)
        {
            var petOwner = await _context.PetOwners.FindAsync(id);

            if (petOwner == null)
            {
                return NotFound();
            }

            return petOwner;
        }

        // PUT: api/PetOwners/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [EnableCors("reactAPP")]
        public async Task<IActionResult> PutPetOwner(int id, PetOwner petOwner)
        {
            if (id != petOwner.Id)
            {
                return BadRequest();
            }

            PetOwner owner = _context.PetOwners.Find(id);
            if (owner == null)
            {
                return NotFound();
            }
            else
            {
                owner.Address = petOwner.Address;
                owner.Name = petOwner.Name;
                _context.Entry(owner).State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;

            }

            return Ok(owner);
        }

        // POST: api/PetOwners
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<PetOwner>> PostPetOwner(PetOwner petOwner)
        {

            var owner = new PetOwner()
            {
                Address = petOwner.Address,
                Name = petOwner.Name
            };

            _context.PetOwners.Add(owner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPetOwner", new { id = owner.Id }, owner);

        }

        // DELETE: api/PetOwners/5
        [HttpDelete("{id}")]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<PetOwner>> DeletePetOwner(int id)
        {
            var petOwner = await _context.PetOwners.FindAsync(id);
            if (petOwner == null)
            {
                return NotFound();
            }

            _context.PetOwners.Remove(petOwner);
            await _context.SaveChangesAsync();

            return petOwner;
        }

        private bool PetOwnerExists(int id)
        {
            return _context.PetOwners.Any(e => e.Id == id);
        }
    }
}
