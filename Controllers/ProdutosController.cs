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
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AutomatizaSistemasContext _context;

        public ProdutosController(AutomatizaSistemasContext context)
        {
            _context = context;
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoItem>>> Getprodutos()
        {
          if (_context.produtos == null)
          {
              return NotFound();
          }
            return await _context.produtos.ToListAsync();
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoItem>> GetProdutoItem(long id)
        {
          if (_context.produtos == null)
          {
              return NotFound();
          }
            var produtoItem = await _context.produtos.FindAsync(id);

            if (produtoItem == null)
            {
                return NotFound();
            }
            var result = new { 
                produtoItem.Id,
                produtoItem.Descricao,
                produtoItem.PrecoVenda,
                produtoItem.MarcaId,
                produtoItem.Status,
                produtoItem.Estoque,
                ValorTotalEstoque = produtoItem.Estoque * produtoItem.PrecoVenda 
            };

            return Ok(result);
        }

        // PUT: api/Produtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdutoItem(long id, ProdutoItem produtoItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != produtoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(produtoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoItemExists(id))
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

        // POST: api/Produtos
        [HttpPost]
        public async Task<ActionResult<ProdutoItem>> PostProdutoItem(ProdutoItem produtoItem)
        {
          if (!ModelState.IsValid)
          {
            return BadRequest(ModelState);
          }
          if (_context.produtos == null)
          {
              return Problem("Entity set 'AutomatizaSistemasContext.produtos'  is null.");
          }
            _context.produtos.Add(produtoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutoItem", new { id = produtoItem.Id }, produtoItem);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdutoItem(long id)
        {
            if (_context.produtos == null)
            {
                return NotFound();
            }
            var produtoItem = await _context.produtos.FindAsync(id);
            if (produtoItem == null)
            {
                return NotFound();
            }

            produtoItem.Status = "REMOVIDO";
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoItemExists(long id)
        {
            return (_context.produtos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
