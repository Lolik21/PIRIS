using AutoMapper;
using PirisWebApp.Models;
using PirisWebApp.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PirisWebApp.AutoMapper.Profiles
{
    public class UserModelProfile : Profile
    {
        public UserModelProfile()
        {
            CreateMap<BankClientViewModel, BankClient>();
        }
    }
}
