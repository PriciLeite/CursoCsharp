using System;
using CursoCsharp.aula_14_Interfaces.Exe.semInterface.Entities;



namespace CursoCsharp.aula_14_Interfaces.Exe.semInterface.Services
{
    class RentalServices
    {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        // private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices(); ---> Substituido pela Interface --->
        private ITaxService _taxService;



        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }



        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Fininsh.Subtract(carRental.Start); //Duração de aluguel -> final - inicial

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {                                  // Payment per hour
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //Math.Ceiling -> arredondar para cima
            }                                                                          // |--> teto 
            else
            {                                  // Payment per Day
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            carRental.invoice = new Invoice(basicPayment, tax);



        }







    }
}
