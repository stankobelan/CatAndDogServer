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
    public class ContactsController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactsController(DataContext context)
        {
            _context = context;
        }

        // POST: api/Contacts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [EnableCors("reactAPP")]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            Contact res = new Contact()
            {
                Subject = contact?.Subject,
                Email = contact?.Email,
                Name = contact?.Name,
                Phone = contact?.Phone,
                Description = contact?.Description,
                Created = DateTime.Now,
                Answered = false,
                Updated = DateTime.Now
            };

            _context.Contacts.Add(res);
            await _context.SaveChangesAsync();

            return Ok(res);
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}
