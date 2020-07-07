using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.DTOs
{
    public class StudentDTO
    {
        public string Code { get; set; }
        public string AddressId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Fullname { get; set; }
    }
}
