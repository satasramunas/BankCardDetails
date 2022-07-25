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
        public int Id { get; set; }

        //[Required]
        public string CardHolderName { get; set; }

        //[Required]
        public string CardNumber { get; set; }

        //[Required]
        public string ExpiryMonth { get; set; }

        //[Required]
        public string ExpiryYear { get; set; }

        //[Required]
        [RegularExpression("^[0-9]{3}$")]
        public string CVC { get; set; }
    }
}
