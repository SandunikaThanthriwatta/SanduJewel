using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanduJewel.Models;

namespace SanduJewel
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelleriesController : ControllerBase
    {
        private readonly Context _context = new Context();

        // GET: api/Jewelleries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jewellery>>> GetJewelleries()
        {
            return await _context.Jewelleries.ToListAsync();
        }

        // GET: api/Jewelleries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jewellery>> GetJewellery(int id)
        {
            var jewellery = await _context.Jewelleries.FindAsync(id);

            if (jewellery == null)
            {
                return NotFound();
            }

            return jewellery;
        }

        // PUT: api/Jewelleries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJewellery(int id, Jewellery jewellery)
        {
            if (id != jewellery.J_number)
            {
                return BadRequest();
            }

            _context.Entry(jewellery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JewelleryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Jewelleries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jewellery>> PostJewellery(Jewellery jewellery)
        {
            _context.Jewelleries.Add(jewellery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJewellery", new { id = jewellery.J_number }, jewellery);
        }

        // DELETE: api/Jewelleries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJewellery(int id)
        {
            var jewellery = await _context.Jewelleries.FindAsync(id);
            if (jewellery == null)
            {
                return NotFound();
            }

            _context.Jewelleries.Remove(jewellery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JewelleryExists(int id)
        {
            return _context.Jewelleries.Any(e => e.J_number == id);
        }
    }
}
