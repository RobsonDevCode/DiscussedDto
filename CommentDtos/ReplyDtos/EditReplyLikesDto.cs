using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos.ReplyDtos
{
    public class EditReplyLikesDto
    {
        public Guid ReplyId { get; set; }
        public Guid UserId { get; set; }
        public bool IsLiked { get; set; }
    }
}
