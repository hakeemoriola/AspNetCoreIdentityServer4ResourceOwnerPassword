﻿using System.Collections.Generic;
using System.Security.Claims;

namespace CustomIdentityServer4.UserServices
{
    public class CustomUser
    {
            public string SubjectId { get; set; }
            public string Email { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public List<Claim> Claims { get; set; }
    }
}