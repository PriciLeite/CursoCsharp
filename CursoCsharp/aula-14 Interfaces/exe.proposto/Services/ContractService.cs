using System;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Services;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Entities;

namespace CursoCsharp.aula_14_Interfaces.exe.proposto.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;  // return valor dá parcela sem os juros e taxas.
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }




    }

}
