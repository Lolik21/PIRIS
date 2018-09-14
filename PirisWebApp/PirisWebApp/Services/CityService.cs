using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PirisWebApp.Models.Database;
using PirisWebApp.Models.Internal;
using PirisWebApp.Services.Interfaces;

namespace PirisWebApp.Services
{
    public class CityService : ICityService
    {
        private readonly VGGContext _dataBaseContext;
        public CityService(VGGContext context)
        {
            _dataBaseContext = context;
        }

        public async Task<List<City>> GetAllCites()
        {
            return await _dataBaseContext.Cites.ToListAsync();
        }

    }
}