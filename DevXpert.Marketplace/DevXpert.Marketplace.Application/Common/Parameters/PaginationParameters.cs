﻿using DevXpert.Marketplace.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Application.Common;

public class PaginationParameters
{
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;

    public int PageSize { get; set; } = Configuration.DefaultPageSize;
}
