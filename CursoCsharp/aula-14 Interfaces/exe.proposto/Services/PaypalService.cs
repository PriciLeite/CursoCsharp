﻿using System;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Services;

namespace CursoCsharp.aula_14_Interfaces.exe.proposto.Services
{
    class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }


        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        
    }
}
