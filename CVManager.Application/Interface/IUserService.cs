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
        List<UserAcountDetails> listUser(int? page, string school);
        User getUserInfo();

        Task<int> saveProfile(Guid ID,string name, string school, string phone, string email, string area);
    }
}
