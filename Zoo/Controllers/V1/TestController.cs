﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zoo.Controllers.V1
{
    public class TestController : Controller

    {
        [HttpGet("api/test")]
        public IActionResult Index()
        {
            return Ok(new {result = "Success"});
        }
    }
}
