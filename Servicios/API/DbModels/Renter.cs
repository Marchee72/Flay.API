using System;
using System.Collections.Generic;
using System.Text;

namespace DbModels
{
    public class Renter: User
    {
        public int ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateUntil { get; set; }

        public int ApartmentID { get; set; }
        public Apartment Apartment { get; set; }
    }
}
