using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Service
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IAcountService _acountService;
        private readonly CVManagerDBContext _dbContext;
        public EnterpriseService(IAcountService acountService, CVManagerDBContext dbContext)
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
    }
}
