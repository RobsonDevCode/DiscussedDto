using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiscussedDto.Email
{
    public class EmailDto
    {
        [Required]
        [JsonPropertyName("to_send")]
        public string ToSend { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("key_id")]
        public Guid KeyId { get; set; }
    }
}
