using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendConcesionario.DataContext;
using BackendConcesionario.Models;

namespace BackendConcesionario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly ConcesionarioContext _context;

        public CarFeaturesController(ConcesionarioContext context)
        {
            _context = context;
        }

        // GET: api/CarFeatures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarFeature>>> GetCarsFeatures()
        {
            return await _context.CarsFeatures.ToListAsync();
        }

        // GET: api/CarFeatures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarFeature>> GetCarFeature(int id)
        {
            var carFeature = await _context.CarsFeatures.FindAsync(id);

            if (carFeature == null)
            {
                return NotFound();
            }

            return carFeature;
        }

        // PUT: api/CarFeatures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarFeature(int id, CarFeature carFeature)
        {
            if (id != carFeature.Id)
            {
                return BadRequest();
            }

            _context.Entry(carFeature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarFeatureExists(id))
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

        // POST: api/CarFeatures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarFeature>> PostCarFeature(CarFeature carFeature)
        {
            _context.CarsFeatures.Add(carFeature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarFeature", new { id = carFeature.Id }, carFeature);
        }

        // DELETE: api/CarFeatures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarFeature(int id)
        {
            var carFeature = await _context.CarsFeatures.FindAsync(id);
            if (carFeature == null)
            {
                return NotFound();
            }

            _context.CarsFeatures.Remove(carFeature);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarFeatureExists(int id)
        {
            return _context.CarsFeatures.Any(e => e.Id == id);
        }
    }
}
