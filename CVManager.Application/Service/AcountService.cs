using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Application.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVManager.Data.Entities;

namespace CVManager.Application.Service
{
    public class AcountService : IAcountService
    {
        private readonly CVManagerDBContext _dbContext;
        private readonly IAcountProvider _acountProvider;
        public AcountService(CVManagerDBContext context, IAcountProvider acountProvider)
        {
            this._dbContext = context;
            this._acountProvider = acountProvider;
        }

        public async Task<Acount> get(UserRequest user)
        {
            return await _dbContext.Acounts.FirstOrDefaultAsync(a => a.Username == user.Username && a.Password == user.Password);
        }

        public async Task<int> create(string username, string password, string objectRole)
        {
            Acount acount = new Acount()
            {
                Username = username,
                Password = password,
                ObjectRole = objectRole
            };
            _dbContext.Acounts.Add(acount);
            return await _dbContext.SaveChangesAsync();
        }

        public Guid getAcountIDFromToken()
        {
            var ID = _acountProvider.GetAcountID();
            if (ID == null) return Guid.Empty;
            return Guid.Parse(ID);
        }
    }
}
