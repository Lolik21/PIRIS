using System.Collections.Generic;
using System.Threading.Tasks;
using PirisWebApp.Models.Internal;

namespace PirisWebApp.Services.Interfaces
{
    public interface ICityService
    {
        Task<List<City>> GetAllCites();
    }
}