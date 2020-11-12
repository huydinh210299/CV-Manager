using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IUserService
    {
        Task<int> create(UserAcountDetails user);

        Task<User> getUserByAcountID(Guid acountID);

        User checkUserFromToken();
    }
}
