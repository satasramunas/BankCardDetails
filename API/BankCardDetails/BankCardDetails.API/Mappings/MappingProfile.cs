using AutoMapper;
using BankCardDetails.API.Dtos;
using BankCardDetails.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BankCard, BankCardDto>().ReverseMap();
        }
    }
}
