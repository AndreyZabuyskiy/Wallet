﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ISO { get; set; }
    }
}
