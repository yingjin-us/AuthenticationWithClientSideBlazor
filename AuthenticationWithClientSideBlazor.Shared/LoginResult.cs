﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationWithClientSideBlazor.Shared
{
    public class LoginResult
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
