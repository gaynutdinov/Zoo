﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Zoo.Domain.V1.Response
{
    public class AnimalResponse
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(150)]
        public string Color { get; set; }
        public int Weight { get; set; }
    }
}
