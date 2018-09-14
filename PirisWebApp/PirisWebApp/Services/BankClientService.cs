using AutoMapper;
using PirisWebApp.Models.Internal;
using PirisWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PirisWebApp.Models.Database;

namespace PirisWebApp.Services
{
    public class BankClientService : IBankClientService
    {
        private readonly VGGContext _dataBaseContext;
        private readonly IMapper _mapper;

        public BankClientService(VGGContext context, IMapper mapper)
        {
            _dataBaseContext = context;
            _mapper = mapper;
        }

        public async Task AddClientToDatabase(BankClient bankClient)
        {
            await _dataBaseContext.AddAsync(bankClient);
            await _dataBaseContext.SaveChangesAsync();
        }

        public async Task<List<BankClient>> GetAllClients()
        {
            return await _dataBaseContext.Clients.ToListAsync();
        }

        public async Task UpdateClientInfo(BankClient bankClient)
        {
            var retrievedClient = await _dataBaseContext.Clients.FirstOrDefaultAsync(client =>
                client.Id == bankClient.Id);
            _mapper.Map(bankClient, retrievedClient);
            await _dataBaseContext.SaveChangesAsync();
        }
    }
}
