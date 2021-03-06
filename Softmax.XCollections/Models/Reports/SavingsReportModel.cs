﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softmax.XCollections.Models.Reports
{
    public class SavingsReportModel
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Deposits { get; set; }
        public string Withdrawals { get; set; }
        public string Incomes { get; set; }
    }
}
