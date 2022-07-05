using AutoMapper;
using BankCardDetails.API.Dtos;
using BankCardDetails.API.Models;
using BankCardDetails.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Services
{
    public class BankCardService
    {
        private readonly BankCardRepository _bankCardRepository;
        private readonly IMapper _mapper;

        public BankCardService(BankCardRepository bankCardRepository, IMapper mapper)
        {
            _bankCardRepository = bankCardRepository;
            _mapper = mapper;
        }

        public async Task<List<BankCardDto>> GetAll()
        {
            var entities = await _bankCardRepository.GetAllAsync();

            List<BankCardDto> dtos = _mapper.Map<List<BankCardDto>>(entities);

            return dtos;
        }

        public async Task<BankCardDto> GetById(Guid id)
        {
            var bankCard = await _bankCardRepository.GetByIdAsync(id);

            BankCardDto dto = _mapper.Map<BankCardDto>(bankCard);

            return dto;
        }

        public async Task AddCard(BankCardDto bankCardDto)
        {
            var entity = _mapper.Map<BankCard>(bankCardDto);

            await _bankCardRepository.AddCardAsync(entity);
        }

        public async Task UpdateCard(BankCardDto bankCardDto)
        {
            var entity = _mapper.Map<BankCard>(bankCardDto);

            await _bankCardRepository.UpdateCardAsync(entity);
        }

        public async Task RemoveCard(Guid id)
        {
            await _bankCardRepository.RemoveCardAsync(id);
        }
    }
}
