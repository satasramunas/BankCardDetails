using BankCardDetails.API.Dtos;
using BankCardDetails.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankCardController : ControllerBase
    {
        private readonly BankCardService _bankCardService;

        public BankCardController(BankCardService bankCardService)
        {
            _bankCardService = bankCardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _bankCardService.GetAll());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            try
            {
                return Ok(await _bankCardService.GetById(id));
            }
            catch (Exception)
            {
                return NotFound("Card not found");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] BankCardDto bankCard)
        {
            await _bankCardService.AddCard(bankCard);
            
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCard([FromBody] BankCardDto bankCard)
        {
            await _bankCardService.UpdateCard(bankCard);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> RemoveCard(Guid id)
        {
            try
            {
                await _bankCardService.RemoveCard(id);

                return NoContent();
            }
            catch (Exception)
            {
                return NotFound("Item not found");
            }
        }
    }
}
