using System;
using System.Collections.Generic;
using System.Text;

namespace DbModels
{
    public class Building
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public int AddressNumber { get; set; }

        public ICollection<Apartment> Apartments { get; set; }
    }
}
