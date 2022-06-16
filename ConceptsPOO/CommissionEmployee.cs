﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tCommission percentage: {$"{CommissionPercentage:P2}",18}" +
                $"\n\tSales................: {$"{Sales:C2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
