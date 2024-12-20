using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.CommentDtos.ReplyDtos
{
    public class BaseResponseDto<T> 
    {
        public string? StatusMessage { get; set; }
        public T? Data { get; set; }
    }
}
