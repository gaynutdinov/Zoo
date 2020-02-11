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
    public class EARelationController : Controller
    {
        private readonly DataContext _context;
        public EARelationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(ApiRoutes.EARelations.GetAll)]
        public async Task<ActionResult<IEnumerable<EARelationResponse>>> GetAll()
        {
            var EARelationResponse = new EARelationResponse();
            var result = from r in _context.EARelations
                         join a in _context.Animals on r.AnimalId equals a.Id
                         join e in _context.Employees on r.EmployeeId equals e.Id
                         select new EARelationResponse
                         {
                             RelationId = r.Id,
                             AnimalName = a.Name,
                             EmployeeName = e.Name
                         };
            //foreach (List<string> r in sqlresult) result.Add(sqlresult.ToString());
            return result.ToList();
        }

        [HttpGet(ApiRoutes.EARelations.Get)]
        public IActionResult Get()
        {
            return Ok(new { result = "Get relations" });
        }

        [HttpPut(ApiRoutes.EARelations.Update)]
        public IActionResult Post()
        {
            return Ok(new { result = "Update the relation" });
        }

        [HttpDelete(ApiRoutes.EARelations.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _context.SaveChangesAsync();
            return Ok(new { result = "Animal relation" });
        }

        [HttpPost(ApiRoutes.EARelations.Create)]
        public async Task<IActionResult> Create([FromBody] EARelationRequest eaRelationsRequest)
        {
            EARelation eaRelation = new EARelation
            {
                EmployeeId = eaRelationsRequest.EmployeeId,
                AnimalId = eaRelationsRequest.AnimalId
            };

            await _context.EARelations.AddAsync(eaRelation);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Create", new { id = eaRelation.Id }, eaRelation);
        }
    }
}