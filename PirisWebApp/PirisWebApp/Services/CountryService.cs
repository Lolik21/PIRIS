using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PirisWebApp.Models.Database;
using PirisWebApp.Models.Internal;
using PirisWebApp.Services.Interfaces;

namespace PirisWebApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly VGGContext _dataBaseContext;
        public CountryService(VGGContext context)
        {
            _dataBaseContext = context;
        }
        public async Task<List<Country>> GetAllCountries()
        {
            return await _dataBaseContext.Countries.ToListAsync();
        }
    }
}