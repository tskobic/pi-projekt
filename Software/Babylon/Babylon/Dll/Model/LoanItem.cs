﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class LoanItem
    {
        public int Id { get; set; }
        public Loan Loan { get; set; }
        public Literature Literature { get; set; }
    }
}