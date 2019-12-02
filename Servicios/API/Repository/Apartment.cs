using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Apartment
    {
        public int ID { get; set; }
        public int Floor { get; set; }
        public float Percentage { get; set; }
        public int RoomsNumber { get; set; }
        public int SquareMeters { get; set; }


        public int BuildingID { get; set; }
        public Building Building { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
