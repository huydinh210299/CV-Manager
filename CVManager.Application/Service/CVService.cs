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
    public class CVService : ICVService
    {
        private readonly CVManagerDBContext _dbContext;
        private readonly IAcountProvider _acountProvider;
        public CVService(CVManagerDBContext context, IAcountProvider acountProvider)
        {
            this._dbContext = context;
            this._acountProvider = acountProvider;
        }
        public async Task<int> create(CVInfo cvInfo)
        {
            var ID = _acountProvider.GetAcountID();
            var acountID = Guid.Parse(ID);
            var user = _dbContext.Users.FirstOrDefault(u => u.ID_Acount == acountID);
            if(user == null)
            {
                return 0;
            }
            else
            {
                var cv = new CV()
                {
                    Name = cvInfo.Name,
                    CvName = cvInfo.CvName,
                    Phone = cvInfo.Phone,
                    Email = cvInfo.Email,
                    Html = cvInfo.Html,
                    Css = cvInfo.Css,
                    Type = cvInfo.Type,
                    User = user
                };

                _dbContext.CVs.Add(cv);
                return await _dbContext.SaveChangesAsync();
            }
        }

        public List<CV> getCVbyUserID(User user)
        {
            return _dbContext.CVs.Where(c => c.User == user).ToList();
        }

        public void saveImage(CVInfo cvInfo)
        {
            //var base64String = cvInfo.Avata;
            //var extString = base64String.Split(",")[0];
            //var data = base64String.Split(",")[1];
            //byte[] bytes = Convert.FromBase64String(data);
            //using (var newFile = new FileStream(@"E:\output.png", FileMode.Create))
            //{
            //    newFile.Write(bytes, 0, bytes.Length);
            //    Array.Clear(bytes, 0, bytes.Length);
            //}
        }

        public async Task<int> setMainCV(Guid cvID)
        {
            var cv = await _dbContext.CVs.FirstOrDefaultAsync(c => c.ID == cvID);
            if(cv.Is_choosen == false)
            {
                var user = _acountProvider.getCurrentUser();
                var cvChoosen = _dbContext.CVs.FirstOrDefault(c => c.User == user && c.Is_choosen == true);
                if(cvChoosen != null)
                {
                    cvChoosen.Is_choosen = false;
                }
                cv.Is_choosen = true;
                await _dbContext.SaveChangesAsync();
                return 1;
            }
            else
            {
                return 0;
            }
        }


        //Hàm lấy thông tin cv theo ID
        public CV getByID(Guid cvID)
        {
            return _dbContext.CVs.FirstOrDefault(c => c.ID == cvID);
        }

        //Hàm edit thông tin CV 
        public async Task<int> edit(CVEdit cVEdit)
        {
            var id = cVEdit.ID;
            var cvID = Guid.Parse(id);
            var cv = _dbContext.CVs.FirstOrDefault(c => c.ID == cvID);
            cv.Name = cVEdit.Name;
            cv.Phone = cVEdit.Phone;
            cv.Email = cVEdit.Email;
            cv.Html = cVEdit.Html;
            cv.Css = cVEdit.Css;
            return await _dbContext.SaveChangesAsync();
        }

        public CV getMainByUserID(Guid userID)
        {
            return _dbContext.CVs.FirstOrDefault(cv => cv.User.ID == userID && cv.Is_choosen == true);
        }
    }
}
