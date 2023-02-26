using System;

namespace CursoCsharp.aula_11_Tratamento_de_Excecoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }



        public Reservation()
        {
        }



        public Reservation(int rommNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = rommNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }


    
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }


        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public override string ToString()
        {
            return "Room: " + RoomNumber 
                + ", "
                + "Check-In: " + CheckIn.ToString("dd/MM/yyyy") 
                + ", " 
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration() + " nigths";
        }




    }
}





