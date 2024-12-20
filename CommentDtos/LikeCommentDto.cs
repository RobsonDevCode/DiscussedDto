using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos
{
    public class LikeCommentDto
    {
        public Guid CommentId { get; set; }
        public string UserId { get; set; }
        public bool IsLike { get; set; }
    }
}
