using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.DTOs
{
    class ProfileDTO
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public int Username { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
    }
}
