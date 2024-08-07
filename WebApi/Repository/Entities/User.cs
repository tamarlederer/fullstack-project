﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string tz { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public virtual ICollection<Appointment>? Appointments { get; set; }
    }
}
