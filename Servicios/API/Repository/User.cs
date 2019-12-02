using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }

        public int? ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

    }
}
