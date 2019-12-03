using System;
using System.Collections.Generic;
using System.Text;

namespace DbModels
{
    public class Apartment
    {
        public int ID { get; set; }
        public int Floor { get; set; }
        public string Department { get; set; }
        public decimal Percentage { get; set; }


        public ICollection<Renter> Renters { get; set; }

        public int BuildingID { get; set; }
        public Building Building { get; set; }
    }
}
