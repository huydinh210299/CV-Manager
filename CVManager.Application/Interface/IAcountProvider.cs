using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IAcountProvider
    {
        string GetAcountID();
        string GetToken();
        User getCurrentUser();
    }
}
