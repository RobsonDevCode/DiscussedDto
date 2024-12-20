using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.Auth
{
    public class EncyrptionCredentialsDto
    {
        public Guid Id  { get; set; }
        public string Key { get; set; }
        public string Iv { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
