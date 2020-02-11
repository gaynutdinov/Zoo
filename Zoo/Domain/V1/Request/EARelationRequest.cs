using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain.V1.Request
{
    public class EARelationRequest
    {
        public int EmployeeId { get; set; }
        public int AnimalId { get; set; }
    }
}
