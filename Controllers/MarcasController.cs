using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using automatizasistemas.Models;

namespace automatizasistemas.Controllers
{
    [Route("api/marcas")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly AutomatizaSistemasContext _context;

        public MarcasController(AutomatizaSistemasContext context)
        {
            _context = context;
        }

        // GET: api/Marcas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarcaItem>>> GetMarcaItems()
        {
          if (_context.marcas == null)
          {
              return NotFound();
          }
            return await _context.marcas.ToListAsync();
        }

        // GET: api/Marcas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MarcaItem>> GetMarcaItem(long id)
        {
          if (_context.marcas == null)
          {
              return NotFound();
          }
            var marcaItem = await _context.marcas.FindAsync(id);

            if (marcaItem == null)
            {
                return NotFound();
            }

            return marcaItem;
        }

        // PUT: api/Marcas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcaItem(long id, MarcaItem marcaItem)
        {
            if (id != marcaItem.Id)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(marcaItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaItemExists(id))
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

        // POST: api/Marcas
        [HttpPost]
        public async Task<ActionResult<MarcaItem>> PostMarcaItem(MarcaItem marcaItem)
        {
          if (!ModelState.IsValid)
          {
            return BadRequest(ModelState);
          }
          if (_context.marcas == null)
          {
              return Problem("Entity set 'AutomatizaSistemasContext.MarcaItems'  is null.");
          }
            _context.marcas.Add(marcaItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarcaItem", new { id = marcaItem.Id }, marcaItem);
        }

        // DELETE: api/Marcas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarcaItem(long id)
        {
            if (_context.marcas == null)
            {
                return NotFound();
            }
            var marcaItem = await _context.marcas.FindAsync(id);
            if (marcaItem == null)
            {
                return NotFound();
            }

            marcaItem.Status = "REMOVIDO";
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MarcaItemExists(long id)
        {
            return (_context.marcas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
