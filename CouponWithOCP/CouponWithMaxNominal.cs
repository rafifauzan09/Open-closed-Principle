﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponWithMaxNominal : Coupon
    {
        public double discPercentage = 0;
        public double discNominal = 0;

        public CouponWithMaxNominal(double discPercentage, double discNominal)
        {
            this.discPercentage = discPercentage;
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            double discPercentageInrupiah = discPercentage * originPrice / 100;
            double finalPrice = 0;
            if(discPercentageInrupiah > discNominal)
            {
                finalPrice = originPrice - discNominal;
            }
            else
            {
                finalPrice = originPrice - discPercentageInrupiah;
            }
            return finalPrice;
        }
    }
}
