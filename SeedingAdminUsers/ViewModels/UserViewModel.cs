﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeedingAdminUsers.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSuspended { get; set; }
    }
}