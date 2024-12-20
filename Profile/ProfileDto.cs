using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discusseddto.Profile
{
    public class ProfileDto
    {
        public Guid UserGuid { get; set; }
        public string UserName { get; set; }
        public Guid SelectedUser { get; set; }
        
    }
}
