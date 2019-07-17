using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationWithClientSideBlazor.Shared
{
    public class UserModel
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
