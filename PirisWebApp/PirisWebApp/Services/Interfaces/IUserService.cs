using PirisWebApp.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PirisWebApp.Services.Interfaces
{
    public interface IUserService
    {
        void AddUserToDatabase(User user);
    }
}
