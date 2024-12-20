using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Discusseddto.Email
{
    public class ConfirmationEmailDto
    {

        [JsonPropertyName("email")]
        [Required]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("confirmation_code")]
        [Required]
        public int ConfirmationCode { get; set; } 
    }
}
