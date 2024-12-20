using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos.ReplyDtos
{
    public class EditReplyContentDto
    {
        public Guid CommentId { get; set; }
        public Guid ReplyId { get; set; }
        public Guid UserGuid { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
