﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Exceptions;

public abstract class BadRequestException : ApplicationException
{
    protected BadRequestException(string message) 
        : base("Bad Request", message) { }
}
