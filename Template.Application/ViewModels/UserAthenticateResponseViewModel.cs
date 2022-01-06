﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Application.ViewModels
{
    public class UserAthenticateResponseViewModel
    {
        public UserAthenticateResponseViewModel(UserViewModel user, string token)
        {
            this.User = user;
            this.Token = token;
        }
        public UserViewModel User { get; set; }
        public string Token { get; set; }
    }
}
