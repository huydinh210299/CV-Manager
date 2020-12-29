using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface ICVService
    {
        Task<int> create(CVInfo cvInfo);

        void saveImage(CVInfo cvInfo);
        List<CV> getCVbyUserID(User user);
        Task<int> setMainCV(Guid cvID);
        CV getByID(Guid cvID);
        Task<int> edit(CVEdit cVEdit);
        CV getMainByUserID(Guid userID);
    }
}
