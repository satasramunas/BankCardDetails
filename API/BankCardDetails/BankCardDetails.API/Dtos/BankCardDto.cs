using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Dtos
{
    public class BankCardDto
    {
        public Guid Id { get; set; }

        [Required]
        public string CardHolderName { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public int ExpiryMonth { get; set; }

        [Required]
        public int ExpiryYear { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}$")]
        public int CVC { get; set; }
    }
}
