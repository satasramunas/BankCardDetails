using BankCardDetails.API.Data;
using BankCardDetails.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Repositories
{
    public class BankCardRepository
    {
        private readonly DataContext _dataContext;

        public BankCardRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<BankCard>> GetAllAsync()
        {
            return await _dataContext.BankCards.ToListAsync();
        }

        public async Task<BankCard> GetByIdAsync(Guid id)
        {
            var bankCard = await _dataContext.BankCards.FirstOrDefaultAsync(x => x.Id == id);

            if (bankCard == null)
            {
                throw new Exception();
            }
            return bankCard;
        }

        public async Task AddCardAsync(BankCard bankCard)
        {
            bankCard.Id = Guid.NewGuid();
            _dataContext.BankCards.Add(bankCard);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateCardAsync(BankCard bankCard)
        {
            _dataContext.BankCards.Update(bankCard);
            await _dataContext.SaveChangesAsync();
        }

        public async Task RemoveCardAsync(Guid id)
        {
            var bankCard = await GetByIdAsync(id);

            _dataContext?.BankCards.Remove(bankCard);
            await _dataContext.SaveChangesAsync();
        }
    }
}
