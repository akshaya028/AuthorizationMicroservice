﻿using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.ServiceLayer
{
    interface IRepositoryWrapper
    {
        public string Validate(PortalLoginDetails loginDetails);
    }
}
