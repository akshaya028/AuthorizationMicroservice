﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Models
{
    public interface IAuthManager
    {
        string Validate(PortalLoginDetails loginDetails);
    }
}
