using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Zoo.Domain.V1.Response
{
    public class EmployeeResponse
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}
