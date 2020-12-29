using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Service
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IAcountService _acountService;
        private readonly CVManagerDBContext _dbContext;
        public EnterpriseService(CVManagerDBContext dbContext, IAcountService acountService)
        {
            this._acountService = acountService;
            this._dbContext = dbContext;
        }
        public async Task<int> createEntAcount(EntRegisterInfo entRegisterInfo)
        {
            var user = new UserRequest() { Username = entRegisterInfo.Username, Password = entRegisterInfo.Password };
            var acount = await _acountService.get(user);
            if (acount != null)
            {
                return 0;
            }
            else
            {
                //var newacc = await _acountService.create(entRegisterInfo.Username, entRegisterInfo.Password, "ROLE_ENTERPRISE");
                var newacc = new Acount() {
                    Username = entRegisterInfo.Username,
                    Password = entRegisterInfo.Password,
                    ObjectRole = "ROLE_ENTERPRISE"
                };
                _dbContext.Acounts.Add(newacc);
                var ent = new Enterprise()
                {
                    Name = entRegisterInfo.Name,
                    Email = entRegisterInfo.Email,
                    Phone = entRegisterInfo.Phone,
                    Skype = entRegisterInfo.Skype,
                    Position = entRegisterInfo.Position
                };
                if(entRegisterInfo.Gender == "male")
                {
                    ent.Gender = true;
                }
                else
                {
                    ent.Gender = false;
                }
                _dbContext.Enterprises.Add(ent);
                ent.Acount = newacc;

                var entInfo = new EnterpriseInfo()
                {
                    Company_Name = entRegisterInfo.Company_name,
                    Tax_Code = entRegisterInfo.Tax_code,
                    Area = entRegisterInfo.Area,
                    Phone = entRegisterInfo.Company_phone,
                    Email = entRegisterInfo.Company_Email,
                    Website = entRegisterInfo.Website,
                    Scale = entRegisterInfo.Scale
                };

                _dbContext.EnterpriseInfos.Add(entInfo);
                entInfo.Enterprise = ent;

                return await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Enterprise> getEnterpriseFromAcountID(Guid ID)
        {
            return await _dbContext.Enterprises.FirstOrDefaultAsync(e => e.ID_Acount == ID);
        }

        public async Task<EnterpriseInfo> getEntPriseInfoFromAcountID(Guid ID)
        {
            var enterprise = await this.getEnterpriseFromAcountID(ID);
            return await _dbContext.EnterpriseInfos.FirstOrDefaultAsync(i => i.ID_Enterprise == enterprise.ID);
        }

        public List<Enterprise> getListEnt(string companyName, string area, int page)
        {
            var rs = _dbContext.Enterprises.Include(e => e.EnterpriseInfo).Where(e => (string.IsNullOrEmpty(companyName) || e.EnterpriseInfo.Company_Name.ToLower().Contains(companyName))
                                                    && (string.IsNullOrEmpty(area) || e.EnterpriseInfo.Area == area))
                                                    .Skip(5 * (page - 1)).Take(5).ToList();
            return rs;
        }

        public Enterprise getEntInfo(Guid entID)
        {
            return _dbContext.Enterprises.Include(e => e.EnterpriseInfo)
                    .Include(e => e.Posts).FirstOrDefault(e => e.ID == entID);
        }

    }
}
