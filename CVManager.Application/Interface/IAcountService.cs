using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IAcountService
    {
        Task<Acount> get(UserRequest user);

        Task<int> create(string username, string password, string objectRole);

        Guid getAcountIDFromToken();

    }
}
