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
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(ApiRoutes.Employees.GetAll)]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll() 
        {
            return await _context.Employees.ToListAsync();
        }

        [HttpGet(ApiRoutes.Employees.Get)]
        public IActionResult Get()
        {
            return Ok(new { result = "Get the Employee" });
        }

        [HttpPut(ApiRoutes.Employees.Update)]
        public IActionResult Post()
        {
            return Ok(new { result = "Update the Employee" });
        }

        [HttpDelete(ApiRoutes.Employees.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _context.SaveChangesAsync();
            return Ok(new { result = "Employee deleted" });
        }

        [HttpPost(ApiRoutes.Employees.Create)]
        public async Task<IActionResult> Create([FromBody] EmployeeRequest employeeRequest)
        {
            Employee employee = new Employee
            {
                Name = employeeRequest.Name,
                Age = employeeRequest.Age,
                Department = employeeRequest.Department
            };

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Create", new { id = employee.Id }, employee);
        }
    }
}
