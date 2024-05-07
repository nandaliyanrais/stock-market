using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequest
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be longer than 10 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "CompanyName cannot be longer than 100 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000, ErrorMessage = "Purchase must be between 1 and 1000000000")]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100, ErrorMessage = "LastDiv must be between 0.001 and 100")]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Industry cannot be longer than 100 characters")]
        public string Industry { get; set; } = string.Empty;

        [Range(1, 1000000000, ErrorMessage = "MarketCap must be between 1 and 1000000000")]
        public long MarketCap { get; set; }
    }
}