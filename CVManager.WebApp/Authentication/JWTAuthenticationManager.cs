using CVManager.Application.Interface;
using CVManager.Data.Entities;
using CVManager.WebApp.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace CVManager.Application.Service
{
    class JWTAuthenticationManager : IJWTAuthentication
    {
        //private readonly IDictionary<string, string> users = new Dictionary<string, string> 
        //{{"test1" , "password1"} };

        private readonly string key;
        public JWTAuthenticationManager(string key)
        {
            this.key = key;
        }
        public string Authenticate(string username, string password, Acount acount)
        {
            if (acount == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes(key);
                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                    new Claim("ID", acount.ID.ToString()),
                    new Claim(ClaimTypes.Role, acount.ObjectRole)
                }),

                    Expires = DateTime.UtcNow.AddHours(1),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescription);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}
