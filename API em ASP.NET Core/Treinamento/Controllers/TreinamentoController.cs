using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treinamentos.Config;
using Treinamentos.Models;

namespace Treinamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreinamentoController : ControllerBase
    {
        private readonly Contexto _context;

        public TreinamentoController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Treinamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Treinamento>>> GetTreinamento()
        {
          if (_context.Treinamento == null)
          {
              return NotFound();
          }
            return await _context.Treinamento.ToListAsync();
        }

        // GET: api/Treinamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Treinamento>> GetTreinamento(long id)
        {
          if (_context.Treinamento == null)
          {
              return NotFound();
          }
            var treinamento = await _context.Treinamento.FindAsync(id);

            if (treinamento == null)
            {
                return NotFound();
            }

            return treinamento;
        }

        // PUT: api/Treinamento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreinamento(long id, Treinamento treinamento)
        {
            if (id != treinamento.ID)
            {
                return BadRequest();
            }

            _context.Entry(treinamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreinamentoExists(id))
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

        // POST: api/Treinamento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Treinamento>> PostTreinamento(Treinamento treinamento)
        {
          if (_context.Treinamento == null)
          {
              return Problem("Entity set 'Contexto.Treinamento'  is null.");
          }
            _context.Treinamento.Add(treinamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreinamento", new { id = treinamento.ID }, treinamento);
        }

        // DELETE: api/Treinamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTreinamento(long id)
        {
            if (_context.Treinamento == null)
            {
                return NotFound();
            }
            var treinamento = await _context.Treinamento.FindAsync(id);
            if (treinamento == null)
            {
                return NotFound();
            }

            _context.Treinamento.Remove(treinamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TreinamentoExists(long id)
        {
            return (_context.Treinamento?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
