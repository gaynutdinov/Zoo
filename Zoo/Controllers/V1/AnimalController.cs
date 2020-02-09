using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Zoo.Domain;
using Zoo.Domain.V1;
using Zoo.Domain.V1.Request;
using Zoo.Domain.V1.Response;
using Zoo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Zoo.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AnimalController : Controller
    {
        private readonly DataContext _context;
        public AnimalController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(ApiRoutes.Animals.GetAll)]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAll() 
        {
            return await _context.Animals.ToListAsync();
        }

        [HttpGet(ApiRoutes.Animals.Get)]
        public IActionResult Get()
        {
            return Ok(new { result = "Get the Animal" });
        }

        [HttpPut(ApiRoutes.Animals.Update)]
        public IActionResult Post()
        {
            return Ok(new { result = "Update the Animal" });
        }

        [HttpDelete(ApiRoutes.Animals.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
           

            await _context.SaveChangesAsync();
            return Ok(new { result = "Animal deleted" });
        }

        [HttpPost(ApiRoutes.Animals.Create)]
        public async Task<IActionResult> Create([FromBody] AnimalRequest animalRequest)
        {
            Animal animal = new Animal
            {
                //Id = animalRequest.Id,
                Name = animalRequest.Name,
                Age = animalRequest.Age,
                Color = animalRequest.Color,
                Weight = animalRequest.Weight
            };

            await _context.Animals.AddAsync(animal);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Create", new { id = animal.Id }, animal);
        }
    }
}
