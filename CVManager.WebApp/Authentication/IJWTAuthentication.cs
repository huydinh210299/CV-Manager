using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Authentication
{
    public interface IJWTAuthentication
    {
        String Authenticate(string username, string password, Acount acount);
    }
}
