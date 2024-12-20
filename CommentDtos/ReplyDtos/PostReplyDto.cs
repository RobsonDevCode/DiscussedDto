using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos.ReplyDtos
{
    public class PostReplyDto
    {
        [JsonIgnore]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Guid CommentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Likes { get; set; }

    }
}
