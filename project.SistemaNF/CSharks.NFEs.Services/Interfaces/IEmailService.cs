﻿using CSharks.NFEs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(Email emailConfig);
    }
}
