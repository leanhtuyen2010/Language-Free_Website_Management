﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageClient.DTO
{
    public class UsersDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string ImageUser { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string National { get; set; }
    }
}
