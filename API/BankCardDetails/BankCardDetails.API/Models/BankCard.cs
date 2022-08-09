using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardDetails.API.Models
{
    public class BankCard
    {
        [Key]
        public int Id { get; set; }

        public string CardHolderName { get; set; }

        public string CardNumber { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public int CVC { get; set; }
    }
}
