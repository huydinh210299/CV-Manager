using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IEnterpriseService
    {
        Task<int> createEntAcount(EntRegisterInfo entRegisterInfo);
        Task<Enterprise> getEnterpriseFromAcountID(Guid ID);
        Task<EnterpriseInfo> getEntPriseInfoFromAcountID(Guid ID);
        List<Enterprise> getListEnt(string companyName, string area, int page);
        Enterprise getEntInfo(Guid entID);
    }
}
