using PirisWebApp.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PirisWebApp.Services.Interfaces
{
    public interface IBankClientService
    {
        Task AddClientToDatabase(BankClient bankClient);
        Task<List<BankClient>> GetAllClients();
        Task UpdateClientInfo(BankClient bankClient);
        void DeleteBankClient(int Id);
    }
}
