using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DoctorDto Doctor { get; set; }
        public int UserId { get; set; }
        //public UserDto User { get; set; }
        public int Status { get; set; }

    }
}
