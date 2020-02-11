using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain.V1.Response
{
    public class EARelationResponse
    {
        public int RelationId { get; set; }
        public string AnimalName { get; set; }
        public string EmployeeName { get; set; }
    }
}
