﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussedDto.User
{
    public class LoginDto
    {
        [Required]
        public string UserNameOrEmail { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string KeyId { get; set; } = string.Empty;
    }
}
