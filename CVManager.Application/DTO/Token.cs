using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.Application.DTO
{
    public class TokenResult
    {
        public string Token { get; set; }

        public TokenResult(string token)
        {
            this.Token = token;
        }
    }
}
