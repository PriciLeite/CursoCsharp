using System;


namespace CursoCsharp.aula_14_Interfaces.exe.proposto.Services
{
    interface IOnlinePaymentService
    {

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}

