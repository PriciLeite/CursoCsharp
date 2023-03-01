using System;
using CursoCsharp.aula_14_Interfaces.Exe.semInterface.Entities;
using CursoCsharp.aula_14_Interfaces.Exe.semInterface.Entities;

namespace CursoCsharp.aula_14_Interfaces.Exe.semInterface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Fininsh { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice invoice { get; set; }

        public CarRental(DateTime start, DateTime fininsh, Vehicle vehicle)
        {
            Start = start;
            Fininsh = fininsh;
            Vehicle = vehicle;
            
        }
    }
}
