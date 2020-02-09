﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain
{
    public class AuthentificationResult
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
