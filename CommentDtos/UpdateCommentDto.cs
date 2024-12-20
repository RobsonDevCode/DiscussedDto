using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos
{
    public class UpdateCommentDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } 
        public string Content { get; set; } 
        public DateTime DtUpdated { get; set; }
    }
}
