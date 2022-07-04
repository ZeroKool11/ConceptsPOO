﻿namespace ConceptsPOO
{
    public class BaseCommisionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tBase.................: {$"{CommissionPercentage:P2}",18}";
        }
    }
}
