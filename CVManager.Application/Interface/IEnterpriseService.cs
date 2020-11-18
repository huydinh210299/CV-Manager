using CVManager.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IEnterpriseService
    {
        Task<int> createEntAcount(EntRegisterInfo entRegisterInfo);
    }
}
