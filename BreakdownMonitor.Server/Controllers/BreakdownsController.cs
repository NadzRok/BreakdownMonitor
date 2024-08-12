using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BreakdownMonitor.Server.Context;
using BreakdownMonitor.Server.Entities;
using BreakdownMonitor.Server.DTO;

namespace BreakdownMonitor.Server.Controllers {
    [ApiController]
    [Route("api/breakdowns")]
    public class BreakdownsController : Controller {
        private readonly BreakdownDbContext _context;

        public BreakdownsController(BreakdownDbContext context) {
            _context = context;
        }

        // GET: Breakdowns
        [HttpGet]
        public async Task<IActionResult> GetBreakdowns() {
            return Ok(await _context.Breakdowns.ToListAsync());
        }

        // GET: Breakdowns/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBreakdown(Guid? id) {
            if(id == null) {
                return NotFound();
            }
            var breakdown = await _context.Breakdowns.FirstOrDefaultAsync(m => m.BreakdownReference == id);
            if(breakdown == null) {
                return NotFound();
            }
            return Ok(breakdown);
        }

        // POST: Breakdowns/Create
        [HttpPost]
        public async Task<IActionResult> CreateBreakdown(Breakdown breakdown) {
            if (breakdown == null) {
                BadRequest();
            }
            breakdown.BreakdownReference = Guid.NewGuid();
            await _context.AddAsync(breakdown);
            await _context.SaveChangesAsync();
            return Ok(breakdown);
        }

        // Put: Breakdowns/update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBreakdown(Guid id, Breakdown breakdown) {
            try {
                if(id != breakdown.BreakdownReference) {
                    return BadRequest();
                }
                _context.Update(breakdown);
                await _context.SaveChangesAsync();
            } catch {
                return NotFound();
            }
            return Ok(breakdown);
        }

        // POST: Breakdowns/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakdown(Guid id) {
            if (id == Guid.Empty) {
                return BadRequest();
            }
            var breakdown = await _context.Breakdowns.FirstOrDefaultAsync(x => x.BreakdownReference == id);
            if(breakdown != null) {
                _context.Breakdowns.Remove(breakdown);
                await _context.SaveChangesAsync();
                return Ok(breakdown);
            } else {
                return NotFound();
            }
        }
    }
}
