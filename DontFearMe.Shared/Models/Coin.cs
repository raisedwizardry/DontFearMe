using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DontFearMe.Shared.Models
{
    public class Coin
    {
        public int CoinId { get; set; }
        [Required]
        public string Amount { get; set; }
        [Required]
        public string MintYear { get; set; }
        [Required]
        public string MintCity { get; set; }
        [Required]
        public string Version { get; set; }
        public string CommonName { get; set; }
    }
}
