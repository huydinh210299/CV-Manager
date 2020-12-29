﻿using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Service
{
    public class UserService : IUserService
    {
        private readonly CVManagerDBContext _dbContext;
        private readonly IAcountProvider _acountProvider;
        public UserService(CVManagerDBContext context, IAcountProvider acountProvider)
        {
            this._dbContext = context;
            this._acountProvider = acountProvider;
        }

        public async Task<int> create(UserAcountDetails user)
        {
            Acount a = new Acount()
            {
                Username = user.Username,
                Password = user.Password,
                ObjectRole = "ROLE_USER"
            };
            _dbContext.Acounts.Add(a);
            Guid idAcount = a.ID;

            User u = new User()
            {
                Name = user.Name,
                School = user.School,
                Phone = user.Phone,
                Email = user.Email,
                Area = user.Area,
                ID_Acount = idAcount
            };
            _dbContext.Users.Add(u);

            a.User = u;
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<User> getUserByAcountID(Guid acountID)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.ID_Acount == acountID);
        }

        public User checkUserFromToken()
        {
            var ID = _acountProvider.GetAcountID();
            if (ID == null)
            {
                return null;
            }
            else
            {
                var acountID = Guid.Parse(ID);
                return _dbContext.Users.FirstOrDefault(u => u.ID_Acount == acountID);
            }
        }

        public List<UserAcountDetails> listUser(int? page, string school)
        {
            var Page = page ?? 1;
            var rs = (from u in _dbContext.Users
                      where (string.IsNullOrEmpty(school) || u.School.ToLower().Contains(school.ToLower()))
                      select new UserAcountDetails()
                      {
                          ID = u.ID,
                          Area = u.Area,
                          Email = u.Email,
                          Name = u.Name,
                          School = u.School,
                          Phone = u.Phone
                      }
                      ).Skip(10 * (Page - 1)).Take(10).ToList();
            return rs;
        }

        public User getUserInfo()
        {
            return _acountProvider.getCurrentUser();
        }

        public async Task<int> saveProfile(Guid ID, string name, string school, string phone, string email, string area)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.ID == ID);
            user.Name = name;
            user.Phone = phone;
            user.Email = email;
            user.School = school;
            user.Area = area;
            return await _dbContext.SaveChangesAsync();
        }
    }
}
