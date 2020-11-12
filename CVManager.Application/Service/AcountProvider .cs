using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.Application.Service
{
    public class AcountProvider : IAcountProvider
    {
        private readonly IHttpContextAccessor _context;
        private readonly CVManagerDBContext _dbContext;
        public AcountProvider(IHttpContextAccessor context, CVManagerDBContext dbContext)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
            this._dbContext = dbContext;
        }
        public string GetAcountID()
        {
            var tokenString = this.GetToken();
            if (tokenString == null || tokenString == "") return null;
            else
            {
                var token = new JwtSecurityToken(jwtEncodedString: tokenString);
                return token.Claims.First(c => c.Type == "ID").Value;
            }
            //return  _context.HttpContext.User.Claims
            //    .First(i => i.Type == "ID").Value;
        }
        
        //Hàm lấy chuỗi token
        public string GetToken()
        {
            return _context.HttpContext.Request.Cookies["jwt"];
        }

        //Hàm lấy user hiện tại
        public User getCurrentUser()
        {
            var acountID = this.GetAcountID();
            var ID = Guid.Parse(acountID);
            return _dbContext.Users.FirstOrDefault(u => u.ID_Acount == ID);
        }
    }
}
