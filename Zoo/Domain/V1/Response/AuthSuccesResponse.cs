using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Domain.V1.Response
{
    public class AuthSuccesResponse
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}
