using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Building
    {
        public int ID { get; set; }
        public string Address { get; set; }

        public ICollection<Apartment> Apartments { get; set; }

    }
}
