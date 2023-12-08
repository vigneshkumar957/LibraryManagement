﻿using System;
using System.Collections.Generic;
using DataAccess;

namespace LMS.DataAccess.Entities
{
    public class AuthenticationController : BaseEntityWithID
    {
        public string Name { get; set; }
        public virtual ICollection<AuthenticatingAction> AuthenticatingActions { get; set; } 
    }
}
