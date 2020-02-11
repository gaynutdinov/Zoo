using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain
{
    public class EARelation
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int AnimalId { get; set; }
    }
}
