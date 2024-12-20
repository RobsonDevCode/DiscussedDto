using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiscussedDto.User
{
    public class RegisterDto
    {
        [Required]
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }
        
        [Required]
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        [Required]
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [Required]
        [JsonPropertyName("key_id")]
        public Guid KeyId { get; set; }
    }
}
